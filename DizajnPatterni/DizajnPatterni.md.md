**Strategy Pattern**
Uloga ovog paterna je izdvajanje algoritma iz maticne klase i ukljucivanje u posebne klase. Pogodan je za primjenjivanje razlicitih algoritama na istom problemu. Algoritmi su neovisni od klijenta koji ih koristi. Podržava otvoren-zatvoren princip i uklanja probleme sa razbacnim if iskazima u programu.

Ovaj patern nije korišten u projektu, ali bi se mogao koristiti kod odabira strategije tj. postavljanja i promjene formacije timova.

**Observer Pattern**
Uloga ovog paterna je da uspostavi vezu izmedu nekog objekta (subject), sa jednim ili vise objekata koji zavise od subjekta (observers) i obavještava ih automatski o svakoj promjeni stanja pozivajuci neke njihove metode. Najcešce se koristi u softwerima koji su vodeni dogadajima, ali ima i bitnu ulogu u MVC paternima.

Ovaj patern nije korišten u projektu, ali bi se mogao iskoristiti kad bi se implementirala funkcionalnost pracenja simulacije utakmice. Tu bi se koristio pri raznim dogadajima npr. promjene rezultata, kartona, povreda itd.

**Decorator pattern**
Uloga ovog paterna je da omoguci staticko ili dinamicko dodavanje novih elemenata i ponašanja(funkcionalnosti) individualnih objekata, bez utjecaja na ponašanje drugih objekata iste klase. Cesto se koristi uz princip pojedinacne odgovornosti.

Ovaj patern nije korišten u projektu, ali bi se mogao iskoristiti kad bi se implementirala ista funkcionalnost kao kod Observer patterna. Tu bi se koristio pri dinamickoj promjeni pozicije igraca u toku simulacije utakmice.
