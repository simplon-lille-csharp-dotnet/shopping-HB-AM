namespace Shopping-HB_AM;

public class Panier
{
    private List<Article> articles;
}

public Panier()
{
    articles = new List<Article>();
}

public void AjouterArticle(Article article)
{
    articles.add(article);
    Console.WriteLine($"{article.Nom} ajouté au panier");
}

public void AfficherPanier()
{
    foreach (var article in articles)
    {
        Console.WriteLine($"{article.Nom} : {article¨.Prix}\n{article.Description}");
    }
}