using System;

namespace Shopping-HB_AM;

    class Program
{
    static void Main(string[] args)
    {

        ///a retirer et mettre les articles dispo a la place
        Article article = new Articles
        {
            Nom = "Ordi",
            Prix = 999.99
        };


        Panier panier = new Panier();

        panier.AjouterArticle(article);)
        panier.AfficherPanier();
}
}