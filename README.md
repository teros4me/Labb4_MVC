Kurs: Webbapplikationer i C#, ASP.NET

Uppgift: MVC

# Om uppgiften

I denna Övning kommer du att bygga en applikation som arbetar mot en bok databas för ett bibliotek. 
En MVC applikation ska vara ansvarig för att behandla och leverera data som finns i databasen.

- [ ]  Skapa ett nytt projekt .
- [ ]  Du behöver en tabell för att jobba med kunder och det ska vara en Customer model.
    - [ ]  Du ska ha minst fyra eller fler fält i Customer klassen.
    - [ ]  Kolumnerna skall formateras i modellerna t.ex. kan Customer.name vara Requierd , StringLenght, Min=16 och Max = 50
    - [ ]  En customer kan låna en eller flera böcker. En bok kan lånas av många customers
    - [ ]  Det måste gå att se om en bok är återlämnad oberoende av lånetiden.
    - [ ]  Du ska bygga tabellerna med hjälp av EF.
    - [ ]  Du kan skapa exempeldata när tabellen skapas.
- [ ]  Du ska hämta alla customers som är i DB
- [ ]  Du ska hämta en specifikt customer med sin id .
- [ ]  Vi vill att kunna editera , skapa och ta bort en customer .
- [ ]  Vi vill se alla böcker som en customer har lånat.
