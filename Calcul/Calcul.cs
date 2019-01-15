using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calcul
{
    public class Calcul
    {
              
        public event EventHandler<DebutCalculEventsArgs> MessageDebut;
        public event EventHandler<FinCalculEventsArgs> MessageFin;
        public event EventHandler<ReturnCompteurEventArgs> ReturnCompteur;
        // C'est cette variable qui permet d'arrêter la thread 
        CancellationTokenSource _cancelCalculAsync;

        
        
        public void AfficheMessageDebut()
        {
            if (MessageDebut != null)
                MessageDebut(this, new DebutCalculEventsArgs { MessageDebut = "Début du calcul" });
        }
        public void AfficheMessageFin()
        {
            if (MessageFin != null)
                MessageFin(this, new FinCalculEventsArgs { MessageFin = "Fin du calcul" });
        }
        public long FonctionCalcul(long Compteur , TaskScheduler scheduler, CancellationToken ct)
        {
            int i;
            for (i = 0; i < Compteur; i++)
            {
                if (ct.IsCancellationRequested)
                {
                    return i;
                }

                Thread.Sleep(10);
                if (scheduler != null)
                {
                    //On demande à la thread graphique de venir exécuter cette tâche car c'est le TaskScheduler de la thread graphique qu'on reçoit en paramètre
                    Task.Factory.StartNew(() =>
                    {
                        if (ReturnCompteur != null)
                            ReturnCompteur(this, new ReturnCompteurEventArgs { returnCompteur = i });
                    }, CancellationToken.None, TaskCreationOptions.None, scheduler);
                }
            }
            return i;
        }

       public  Task<long> FonctionCalculAsync(long Compteur )
        {
            TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();

            // Le CancellationTokenSource ne peut servir qu'une fois. Il faut en créer un nouveau à chaque utilisation. Comme il est 
            // Disposable, il faut appeler la méthode Dispose avant de créer le nouveau
            if (_cancelCalculAsync != null)
            {
                _cancelCalculAsync.Dispose();
            }
            _cancelCalculAsync = new CancellationTokenSource();
            return   Task<long>.Run(() => { return FonctionCalcul(Compteur, scheduler, _cancelCalculAsync.Token); });
        }

      public void StopCalculAsync()
        {
            if (_cancelCalculAsync != null)
            {
                _cancelCalculAsync.Cancel();
                
            }
        }
      
    }
}
