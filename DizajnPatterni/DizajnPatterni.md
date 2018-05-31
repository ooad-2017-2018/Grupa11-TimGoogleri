**Strategy Pattern**
 
Uloga ovog paterna je izdvajanje algoritma iz maticne klase i ukljucivanje u posebne klase. Pogodan je za primjenjivanje razlicitih algoritama na istom problemu. Algoritmi su neovisni od klijenta koji ih koristi. Podržava otvoren-zatvoren princip i uklanja probleme sa razbacnim if iskazima u programu.

Ovaj patern nije korišten u projektu, ali bi se mogao koristiti kod odabira strategije tj. postavljanja i promjene formacije timova.

**Observer Pattern**

Uloga ovog paterna je da uspostavi vezu izmedu nekog objekta (subject), sa jednim ili vise objekata koji zavise od subjekta (observers) i obavještava ih automatski o svakoj promjeni stanja pozivajuci neke njihove metode. Najcešce se koristi u softwerima koji su vodeni dogadajima, ali ima i bitnu ulogu u MVC paternima.

Ovaj patern nije korišten u projektu, ali bi se mogao iskoristiti kad bi se implementirala funkcionalnost pracenja simulacije utakmice. Tu bi se koristio pri raznim dogadajima npr. promjene rezultata, kartona, povreda itd.

**Decorator pattern**

Uloga ovog paterna je da omoguci staticko ili dinamicko dodavanje novih elemenata i ponašanja(funkcionalnosti) individualnih objekata, bez utjecaja na ponašanje drugih objekata iste klase. Cesto se koristi uz princip pojedinacne odgovornosti.

Ovaj patern nije korišten u projektu, ali bi se mogao iskoristiti kad bi se implementirala ista funkcionalnost kao kod Observer patterna. Tu bi se koristio pri dinamickoj promjeni pozicije igraca u toku simulacije utakmice.

**Lazy initialization**

U softtware development-u, lazy initialization je strategija odgađanja kreiranja objekta, računanja vrijednosti ili nekog drugog "skupog" procesa dok ne bude potreban. Ovo se obično postiže proširivanjem gettera da provjere da li je privatni atribut vec inicijaliziran. Ako jeste, odmah se vraća, dok ako nije, kreira se nova instanca, inicijalizira se privatni atribut, i vraća se "just-in-time" za prvu upotrebu.

Ako objekti imaju atribute koji se rijetko koriste, ovo može ubrzati brzinu pokretanja programa. Srednja vrijednost performansi programa u smislu memorije može biti malo lošija, ali uticaj instantacije objekata na start-up fazu programa je amortizovan zbog toga što su instantacije vremenski raspoređene, te se time srednja vrijednost vremena odziva mnogo poboljšava.

**Factory method**

Factory method je jedan od 23 dobro poznata "Gang of Four" dizajn pattern-a koji opisuju kako riješiti ponavljajuće probleme sa dizajnom, da bi dizajnirali fleksibilan i za višekratnu upotrebu objektno orijentisani software tj. objekti koje je lakše implementirati, mijenjati, testirati i ponovno koristiti.

Factory method opisuje kako:
-definirati odvojenu operaciju za kreiranje objekta
-kreirati objekat pozivanjem factory metode

Ovo omogućuje pisanje subklasa da promjene način na koji se kreira objekat.

**Multiton pattern**

Multiton pattern je dizajn pattern sličan singlotonu, koji dozvoljava da se samo jedna instanca klase kreira. Multiton pattern proširuje singltonov koncept tako što čuva mapu imenovanih instanci kao ključ-vrijednost parove.

Većina stručnjaka i knjiga smatraju ovaj dizajn pattern singleton pattern-om. Na primjer multiton se eksplicitno ne pojavljuje u cijenjenoj knjizi "Design Patterns" već se spominja kao registar singleton-a.

**Adapter pattern**

Adapter pattern je dizajn pattern (još poznat kao Wrapper) koji dozvoljava da se interface postojeće klase koristi kao drugi interface. Najčešće se koristi da se omogući postojećim klasama da rade sa drugim klasama bez modificiranja koda.

Adapter pattern opisuje kako riješiti probleme poput:
-definiranja odvojene Adapter klase koja konvertuje (nekomaptibilan) interface određene klase u drugi interface koji je potreban klijentima
-kako raditi kroz Adapter da bi se radilo sa klasama koje nemaju potreban interface

**Bridge pattern**

Bridge pattern je dizajn pattern koji bi trebao "razdvojiti apstrakciju od njene implementacije tako da mogu varirati neovisno jedno od drugog". 
Bridge koristi enkapsulaciju, agregaciju i može koristiti nasljeđivanje da razdvoji odgovornosti u različite klase.

Za bridge pattern se često greškom misli da je adapter pattern. Zapravo, bridge pattern se često implementira koristeći Adapter klasu.

**Composite pattern**

Composite pattern je particioniran dizajn pattern. Ovaj dizajn pattern opisuje grupu objekata koji se tretiraju na isti način kao jedna instanca istog tipa objekta. Namjera ovog dizajn patterna je da sastavi objekte u strukture poput stabla te da predstavljaju "part-whole" hijerarhije. Implementacijom ovog dizajn pattern-a dopušta klijentima da tretiraju individualne objekte i kompozicije objekata isto.

Composite pattern opisuje rješenja za probleme poput:
-definiranje jedinstvenog Component interface-a i za Leaf objekte i za cjelinu
-individualni Leaf objekti implementiraju Component interface direktno, a Composite objekti porsljeđuju zahtjeve njihovim "child" komponentama



