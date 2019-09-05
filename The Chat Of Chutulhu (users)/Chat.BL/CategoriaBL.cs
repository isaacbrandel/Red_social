using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.BL
{
    public class CategoriaBL
    {
        public List<Categoria> MostrarCategorias()
        {
            var categoria1 = new Categoria();
            categoria1.ID = 1;
            categoria1.Nombre = "Terror";
            categoria1.Descripcion = "Los libros de terror apuntan directamente a los miedos más primordiales, a la sensación de soledad y abandono, a los puntos débiles que todos compartimos. No se trata solamente de asustar, de hacer pegar un salto al lector, sino de capturarle poco a poco en una espiral de tensión que le haga clavar las uñas en las páginas del libro. Desde los clásicos victorianos como Drácula al costumbrismo siniestro de Stephen King, las novelas de horror saben cómo retorcer la realidad para que al final seamos incapaces de sentirnos seguros al apagar las luces de nuestra habitación antes de irnos a dormir";

            var categoria2 = new Categoria();
            categoria2.ID = 2;
            categoria2.Nombre = "Romance";
            categoria2.Descripcion = "Los libros románticos cuentan historias inolvidables, llenas de pasión y de sentimientos más fuertes que cualquier dificultad. En estas novelas no puede faltar una buena ambientación, bien sea histórica, con especial atención a épocas como la regencia inglesa o la época victoriana, o exótica, con parajes de ensueño. Además, el lujo y la riqueza son también una parte importante de las historias llenas de adulterio y engaño. El romance es cambiante y así lo son también sus historias, siempre en busca de despertar en el lector una pasión incombustible. ¿Podrás resistirte a la llamada de un fiero pirata o un highlander enamorado que ha viajado en el tiempo sólo para encontrarte?";

            var categoria3 = new Categoria();
            categoria3.ID = 3;
            categoria3.Nombre = "Infantiles";
            categoria3.Descripcion = "La literatura infantil y juvenil se ha convertido a lo largo de los años en algo más que una manera de inculcar valores y mensajes a los más jóvenes. La calidad y el gusto por la buena literatura ha convencido a muchos autores para dedicarse a tejer historias que no sólo entretienen, sino que han logrado convertirse en verdaderos fenómenos. Desde los libros más adecuados para el ámbito educativo a los grandes premios, como el Barco de Vapor o el Everest, encontramos también aquellos que bordean la narrativa adulta, como las novelas de Crepúsculo o los últimos libros de Harry Potter.";

            var Lista_Categoria = new List<Categoria>();
            Lista_Categoria.Add(categoria1);
            Lista_Categoria.Add(categoria2);
            Lista_Categoria.Add(categoria3);
            return Lista_Categoria;
        }
    }
}
