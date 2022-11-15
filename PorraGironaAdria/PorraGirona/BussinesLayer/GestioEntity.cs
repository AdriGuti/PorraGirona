using PorraGirona.DataLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorraGirona.BussinesLayer
{
    public class GestioEntity
    {
        static PostDbContext connexio;
        public static string ErrorMessage="";
        #region DataBindings
        static public List<Penyistes> DataSourceBindingSourcePenyistes()
        {
            List<Penyistes> penyi = new List<Penyistes>();
            try
            {
                connexio = new PostDbContext();
                penyi = connexio.Penyistes.ToList();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return penyi;
        }
        static public List<Puntuacions> DataSourceBindingSourcePuntuacions()
        {
            List<Puntuacions> punts = new List<Puntuacions>();
            try
            {
                connexio = new PostDbContext();
                punts = connexio.Puntuacions.ToList();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return punts;
        }
        #endregion
        #region CRUD
        static public bool InsereixPenyista(Penyistes penyi)
        {
            bool correcte = true;
            try
            {
                if (connexio.Penyistes.Contains(penyi))
                {
                    connexio.Penyistes.Update(penyi);
                }
                else
                {
                    connexio.Penyistes.Add(penyi);
                }
                connexio.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                correcte = false;
            }
            return correcte;
        }
        static public void SuprimirUsuari(Penyistes penyi)
        {
            connexio.Penyistes.Remove(penyi);
            connexio.SaveChanges();
        }
        #endregion
        static public bool LoginPenyista(string alias,string pass)
        {

            bool loginsuccesful = false;
            try
            {
                connexio = new PostDbContext();
                if (connexio.Penyistes.Where(a => a.Alias == alias && a.Password == pass).Count() == 1)
                {
                    loginsuccesful = true;
                }
                else
                {
                    ErrorMessage = "Usuari o contrasenya incorrecta";
                }
        }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return loginsuccesful;
        }

        static public bool CalculaPuntuacionsEntity()
        {
            bool procCorrect = false;
            try
            {
                        connexio = new PostDbContext();
                List<Puntuacions> puntslist = connexio.Puntuacions.ToList();
                connexio.Puntuacions.RemoveRange(puntslist);
                #region Calcul de les puntuacions
                int puntuacio = 0;
                var penyistes = connexio.Penyistes.ToList();
                foreach (Penyistes penyi in penyistes)
                {
                    Puntuacions punts = new Puntuacions();
                    puntuacio = 0;
                    punts.Puntuacio = 0;
                    punts.Idpenyista = penyi.Idpenyista;
                    var porresdelPenyi = connexio.Porres.Where(p => p.Idpenyista == penyi.Idpenyista).ToList<Porres>();
                    foreach (Porres porra in porresdelPenyi)
                    {
                        Partits partit = new Partits();
                        partit = (Partits)connexio.Partits.Where(p => p.Idpartit == porra.Idpartit).First();
                        puntuacio += GestioMisc.CalculaPuntsUnaPorra(porra, partit);
                    }
                    punts.Puntuacio = puntuacio;
                    connexio.Puntuacions.Add(punts);
                }
                #endregion
                #region Manera Alternativa de Calcular Puntuacions
                // MANERA ALTERNATIVA DE CALCULAR LES PUNTUACIONS
                //(NO SUMA LES PUNTUACIONS DE CADA PENYISTA)
                //var porres = connexio.Porres.ToList();
                //foreach (Porres porra in porres)
                //{
                //    Partits partit = new Partits();
                //    Puntuacions punts = new Puntuacions();
                //    punts.Puntuacio = 0;
                //    partit = (Partits)connexio.Partits.Where(p => p.Idpartit == porra.Idpartit).First();
                //    punts.Idpenyista = (int)porra.Idpenyista;
                //    punts.Puntuacio = CalculaPuntsUnaPorra(porra, partit);
                //    punts.Temporada = partit.Temporada;
                //    connexio.Puntuacions.Add(punts);
                //}
                #endregion Manera Alternatica de Calcular Puntuacions
                connexio.SaveChanges();
                procCorrect = true;
            }
            catch(Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return procCorrect;
        }
    }
}
