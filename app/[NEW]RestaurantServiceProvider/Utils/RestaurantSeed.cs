using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    public static class RestaurantSeed
    {
        public static Restaurant[] CreateRestaurants()
        {
            return new Restaurant[11]
            {
                Restaurant.Create("Panck's", "Bld. Tudor Vladimirescu, et.2", "Clatite americane reinventate, arome delicioase"),
                Restaurant.Create("La Placinte", "Bld. Carol I nr.4 ", "Va asteptam intr-o ambianţă originală, cu puternice accente tradiţionale moldoveneşti si cu un meniu foarte atractiv."),
                Restaurant.Create("Oliv", "Strada Silvestru nr. 4, Iași 700259", "Culoarea are gust."),
                Restaurant.Create("Fenice", "3F, Strada Palas, Iași 700032", "Sophisticated and tempting restaurant. Located in the historic core of the city, near the Palace of Culture in the Palas ensemble which is \"city in the heart of the city\".Elegant interior and luxurious atmosphere."),
                Restaurant.Create("Mado Palas", "Palas Food Court, Strada Palas 5C, Iași 700259", "Puterea gustului!"),
                Restaurant.Create("The Trumpets", "Esplanada Teatrul Luceafărul, Iași 700259", "The Trumpets este locul în care, lăsănd grijile la o parte, se amplifică simțurile și deschiderea către distracție. Auzul, gustul, simțul olfactiv și cel tactil, sunt celebrate în cadrul pub-ului pentru a-ți reda buna dispoziție după ce ai petrecut o zi cu ochii în calculator, rapoarte sau facturi. Fiindcă cercetătorii britanici au descoperit că partea plină a paharului se vede cel mai bine atunci când iți aduce chelnerul următorul rând."),
                Restaurant.Create("Chef Galerie", "Strada Palat 3F, Iași 700032", "Grilling to perfection is not a goal it's a MUST!"),
                Restaurant.Create("Legend Pub", "Strada Grigore Ureche nr. 27, Iași 700044", "Legend este locul unde berea e mai rece decât ți-ai putea imagina, mâncarea este mai bună decât atunci când nu mai poți de foame, iar petrecerile sunt mai nebune decât orice-ai văzut înainte. De ce? Fiindcă trăim totul la superlativ. Despre asta este #Legend"),
                Restaurant.Create("C House Lounge", "Shopping Street, Iași 700051", "Pentru că prietenii merg mână în mână cu un cocktail bun, cafeaua italiană merge perfect cu diminețile pline de soare și weekendurile nu sunt la fel fără o masă cu savori italiene alese, alături de familie, s-a creat C-House!"),
                Restaurant.Create("Treaz & Nu", "Strada Palas", "Construit dintr-o idee grozavă și nu liniștită, Treaz & Nu este primul local conceptual din oraș menit să-i gâdile pe iubitorii de vinuri și pasionații de cafea.Credem că pe lume există prea puțină cafea de specialitate și vinuri de calitate, pentru câte lucruri avem să ne spunem. Așa că hai să le-ncercăm pe toate!"),
                Restaurant.Create("Carbon", "Strada Palas nr. 7A, Iași 700051", "Carbon a fost creat pentru a redefini experienta gastronomica."),
            };
        }
    }
}
