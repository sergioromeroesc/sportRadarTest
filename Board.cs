using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRadarText
{
    public class Board
    {
        List<Partido> lstPartidos = new List<Partido>();

        public void anadirPartido(string local, string visitante)
        {
            //creamos partido y añadimos a la lista
            int nElementos = lstPartidos.Count;
            Partido p = new Partido(local, visitante, nElementos);
            lstPartidos.Add(p);            
        }

        public void finalizarPartido(string local, string visitante)
        {
            //buscamos el partido en la lista y lo removemos
            Partido p = lstPartidos.Where(t => t.teamLocal == local && t.teamVisitante == visitante).FirstOrDefault();
            lstPartidos.Remove(p);
        }

        public void actualizarResultado(string local, string visitante, int golesLocal, int golesVisitante)
        {            
            //buscamos índice del partido y actualizamos goles
            int indice = lstPartidos.FindIndex(t => t.teamLocal == local && t.teamVisitante == visitante);
            lstPartidos[indice].golesLocal = golesLocal;
            lstPartidos[indice].golesVisitante = golesVisitante;
        }

        public List<Partido> devuelteResultados()
        {
            //ordenamos primero por resultado global, luego por antigüedad en la tabla
            List<Partido> resul = new List<Partido>();
            resul = lstPartidos.OrderByDescending(t=>t.id).OrderByDescending(t => t.golesLocal + t.golesVisitante).ToList();            

            return resul;
        }
    }

    public class Partido
    {
        public int id;//lo usaremos para a la hora de mostrar el listado ordenado poder ordenar por este índice (antigüedad en la tabla)
        public string teamLocal;
        public string teamVisitante;
        public int golesLocal;
        public int golesVisitante;

        public Partido(string local, string visitante, int idLista)
        {
            teamLocal = local;
            teamVisitante = visitante;
            golesLocal = 0;
            golesVisitante = 0;
            id = idLista;
        }
    }
}
