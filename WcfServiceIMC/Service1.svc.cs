using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceIMC
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetIMC(float taille, float poids)
        {
            float imc= (poids) / (taille/100*taille/100);
            if (imc < 16)
            {
                return imc+" : Anorexie ou dénutrition";
            }
            else if (imc < 18.5)
            {
                return imc+" : Maigreur";
            }
            else if (imc < 25)
            {
                return imc + " : Corpulence normale";
            }
            else if (imc < 30)
            {
                return imc + " : Surpoids";
            }
            else if (imc < 35)
            {
                return imc + " : Obésité modérée (Classe 1)";
            }
            else if (imc < 40)
            {
                return imc + " : Obésité élevé (Classe 2)";
            }
            else
            {
                return imc + " : Obésite morbide ou massive";
            }
        }
    }
}
