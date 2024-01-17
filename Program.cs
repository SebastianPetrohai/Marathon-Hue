using Marathon;

Liste vcListe = new("Vienna City Marathon");

vcListe.AddLaeufer(new Laeufer(1,"Max", "Muster\t", 3));
vcListe.AddLaeufer(new Laeufer(2,"Herbert", "Fisher\t", 4));
vcListe.AddLaeufer(new Laeufer(3,"Manfred", "Brugger\t", 5));
vcListe.AddLaeufer(new Laeufer(4,"Daniel", "Mayer\t", 6));
vcListe.AddLaeufer(new Laeufer(5,"Roswitha", "Müller\t", 7));
vcListe.AddLaeufer(new Laeufer(6,"Herta", "Fröhlich\t", 8));

vcListe.Print();