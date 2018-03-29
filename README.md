# Grupa11-TimGoogleri

# ETF Manager

1. Mustafa Šupuk
2. Nedim Tarakčija
3. Orhan Ušanović

## Opis teme

Ova aplikacija pomoći će svima koji imaju san da postanu menadžeri fudbalskog tima i vode ga do uspjeha. Virtualni menadžeri mogu dovoditi željene igrače, postaviti željenu formaciju i postavu, te igračima dati instrukcije kako da igraju. Izazovite prijatelje ili neprijatelje i doživite jedinstveno multiplayer iskustvo.

## Procesi

* **Registracija**

  U slučaju da korisnik ne posjeduje postojeći nalog potrebno je da korisnik prvo kreira nalog. Od korisnika se traži da unese željeno         korisničko ime, lozinku, te e-mail adresu. Također prilikom registracije se provjerava da li je korisničko ime koje je korisnik odabrao jedinstveno te ako nije se od korisnika traži da unese neko drugo korisničko ime.

* **Prijava**

  Omogućava korisniku prijavu na sistem tražeći korisničko ime i lozinku.
   
* **Kreiranje kluba**

  Kada se korisnik prvi put prijavi na sistem ili je iz nekog razloga obrisao svoj postojeći klub, potrebno je da korisnik kreira novi klub. Od korisnika se traži ime kluba koje mora biti jedinstveno.
  
* **Transferi**

  Korisniku se omogućava da vrši transfere, odnosno da kupuje/prodaje igrače u skladu sa budžetom svoga kluba. Korisniku je dat određeni budžet za transfere koje on treba pametno utrošiti za najbolje rezultate.
   
* **Postava taktike**

  Korisniku je omogućeno da izabere formaciju u kojoj će njegov tim izaći na teren, igrače koji će činiti tu formaciju, te strategiju kojom će igraći pristupiti meču.
  
* **Odigravanje meča**

  Odigravanje meča je simulacija po algoritmu koji uzima u obzir vještine igrača, da li korisnikova ekipa utakmicu igra kod kuće ili u gostima, te random događajima koji su tu da simulacije ne bi bile dosadne i predvidive.
  
* **Pregled rezultata meča**  

  Nakon svakog odigranog meča korisniku se nudi mogućnost pregleda rezultata i statistika.
  
* **Objava rezultata**

  Korisniku se nudi mogućnost objave rezultata nakon svake utakmice na društvenim mrežama.

* **Pridruživanje ligi**

  Korisnik može da se pridruži ligi po njegovoj želji. Kada lige imaju potreban broj timova, pridruživanje datoj ligi je onemogućeno i sezona počinje.
  
* **Kreiranje lige**

  Ukoliko se korisniku ne sviđaju postojeće lige ili želi da napravi ligu u kojoj će se takmičiti sa svojim prijateljima to mu je omogućeno ovom funkcionalnošću
   
* **Brisanje lige**

  Ukoliko ima previše liga sa nedovoljnim brojem igrača adminu je omogućeno da obriše lige sa malim brojem igrača da bi se motiviralo igrače da se priključe ligama sa većim brojem klubova.
   
* **Pregled lige**

  Korisnici imaju uvid u poredak timova na ljestvici, poredak najboljih strijelaca, forme svoje ili suparničkih ekipa u prethodnim utakmicama.

* **Brisanje kluba**

  Brisanje kluba je uključeno u brisanje računa, ali također ako korisnik iz nekoga razloga želi da obriše svoj klub i počne iznova to mu je omogućeno. Brisanje kluba je onemogućeno za vrijeme trajanja sezone.

* **Update baze podataka**

  Update baze će se vršiti redovno nakon svake registracije, promjene podataka, promjene forme igrača i odigranih utakmica.
 
* **Brisanje računa**

  Korisnici mogu brisati svoje račune ukoliko ne žele više da se takmiče na virtualnim zelenim terenima. Također admin može obrisati račun ukoliko uoči nepravilnosti ili neki način varanja sa datog računa.
 
* **Kontaktiranje administracije**

  Korisniku se nudi mogućnost kontaktiranja administracije u slučaju pitanja, prijave neregularnosti i varanja, prijave grešaka u aplikaciji i sličnih stvari.
  
* **Dobavljanje podataka sa eksternog sistema**

  Nakon svakog odigranog kola realnog fudbala vršit će se update baze podataka igrača te promjene njihovih sposobnosti u skladu sa njihovom realnom formom da bi se ovoj simulaciji dao dašak realnosti. Ovi podaci će se dobavljati sa eksternog sistema na kojem će se nalaziti sve statistike igrača iz realnog svijeta. 
   
## Funkcionalnosti

* Mogućnost registracije novih korisnika
* Postojeći korisnici imaju svoj račun
* Mogućnost kreiranja vlastitog kluba
* Pridruživanje ligi
* Mogućnost kreiranja vlastite lige
* Mogućnost transfera igrača
* Mogućnost postavljanja taktike
* Odigravanje meča
* Pregled rezultata i statistika nakon odigranog meča
* Mogućnost podjele rezultata na društvenim mrežama
* Mogućnost pregleda lige u kojoj se klub takmiči
* Mogućnost brisanja kluba
* Mogućnost brisanja lige (od strane admina)
* Brisanje korisničkog računa
* Mogućnost kontaktiranja administracije
* Update baze podataka igrača
* Dobavljanje statistika igrača iz realnog svijeta

## Akteri

* Korisnik - Osoba koja ima mogućnost da kreira svoj račun, tim, ligu. Može da upravlja timom, taktikom, transferima i da obriše svoj račun.
* Administrator - Osoba koja upravlja sistemom. Ima mogućnost brisanja korisničkih računa, kreiranja i brisanja lige.
* Eksterni sistem - Sistem koji služi za dobavljanje aktuelnih statistika igrača iz realnog svijeta što se odražava na forme igrača u sistemu.
