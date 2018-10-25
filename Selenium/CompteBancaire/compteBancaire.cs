using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsMBA
{
    public enum enumMonnaie { EUR, USD, GBP }
    public class compteBancaire
    {
        public String Numero { get; set; }
        public Boolean Etat { get; protected set; }
        private Single Solde { get; set; }
        public compteBancaire()
        {
            Etat = true;
            Solde = 0;
        }

        public virtual Single getSolde()
        {
            return Solde;
        }
        public virtual Boolean debiter(Single pMontant)
        {
            Boolean bReturn;
            if (pMontant >= 0 && Etat)
                {
                    Solde = Solde - pMontant;
                    if (Solde < -100)
                    {
                        Etat = false;
                    }
                    bReturn = true;
                }
                else
                {
                    bReturn = false;
                }
            return bReturn;
        }
        public virtual Boolean crediter(Single pMontant)
        {
            if (pMontant >= 0)
            {
                if (Etat)
                {
                    Solde = Solde + pMontant;
                    return true;
                }
                else
                {
                    if (pMontant > Math.Abs(Solde))
                    {
                        Solde = Solde + pMontant;
                        Etat = true;
                        return true;
                    }
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public virtual String translate(String pIn)
        {
            return pIn.ToLower();
        }
    }

    public class compteBancaireV2 : compteBancaire
    {
        public enumMonnaie maMonnaie { get; set; }
        private Single Solde { get; set; }
        public Convertisseur mConvert { get; set; }
        public compteBancaireV2(enumMonnaie pMonnaie ):base()
        {
            maMonnaie = pMonnaie;
            mConvert = new Convertisseur();
        }

        public virtual Single getSolde(enumMonnaie pMonnaie)
        {
            Single taux = getTaux( pMonnaie);
            return base.getSolde()* taux;
        }
        public virtual Boolean debiter(enumMonnaie pMonnaie,Single pMontant)
        {
            Single taux = getTaux(pMonnaie);
            return base.debiter(pMontant*taux);
        }
        public virtual Boolean crediter(enumMonnaie pMonnaie,Single pMontant)
        {
            Single taux = getTaux(pMonnaie);
            return base.crediter(pMontant*taux);
         }
        /// <summary>
        /// Rend le Taux de conversion entre Monnaie
        /// Si la mpnnaie passée en param est egale à la monnaie du compte 
        /// Rend 1
        /// Sinon Appelle le convertisseur
        ///     
        /// </summary>
        /// <param name="pMonnaie"></param>
        /// <returns></returns>
        public Single getTaux(enumMonnaie pMonnaie)
        {
            if (pMonnaie == this.maMonnaie)
            {
                return 1f;
            }
            else
            {
                Single taux = mConvert.getTaux(this.maMonnaie, pMonnaie);
                return taux;
            }
        }//getTaux
    }

}
