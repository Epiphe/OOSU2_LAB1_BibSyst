# OOSU2_LAB1_BibSyst

Uppgiftsbeskrivningen:

Laboration 1
Design av applikation för utlåning av Böcker

Syfte
Syftet med laborationen är att visa förmåga att kunna tillämpa en iterativ process för objektorienterad
analys och design för mjukvaruutveckling, t.ex. enligt Agile Unified Process.

Uppgift
Ett nytt bibliotek, med utlåning av böcker, skall startas upp i Borås. Ni har fått huvudansvaret att
utveckla ett nytt IT-system som skall stödja verksamheten och dess medlemmar. Verksamheten
baseras på att medlemmen ringer upp eller besöker en expedit i affären som i sin tur sköter bokningar
samt utlämning och återlämning av böcker. IT-systemet skall hantera medlemmar, böcker,
bokningar och fakturor. Systemet skall bestå av två delar; en expeditapplikation och en
chefsapplikation. I första hand skall gränssnitten och klasserna i expeditapplikationens affärslager
designas medan chefsapplikationen är en extrauppgift.

Expeditapplikationen
För att få tillgång till expeditapplikationen måste expediten logga in med sitt anställningsnummer
och sitt lösenord. Därefter skall expediten få välja att utföra något av nedanstående:
• Bokning av böcker. Om expediten väljer att boka böcker skall en lista över tillgängliga
böcker visas(en bok är tillgänglig om den inte är bokad eller utlånad). Expediten väljer sedan
ett eller flera tillgängliga böcker, anger medlemmens medlemsnummer och bokar böckerna.
Om bokningen gick igenom fås ett bokningsnummer som ges till medlemmen.
• Borttagning av bokning. Medlemmen anger sitt bokningsnummer och expediten tar bort
bokningen.
• Utlämning av böcker. Medlemmen kommer till biblioteket vid datumet för början av
bokningen (eller senare datum inom det bokade intervallet), anger sitt bokningsnummer och
expediten lämnar ut böckerna.
• Återlämning av böcker. När medlemmen är klar med böckerna, anger medlemmen sitt
bokningsnummer och återlämnar böckerna till expediten. Vid återlämnandet skapas en
faktura som expediten överlämnar till medlemmen och som sparas i systemet. Priset på
utlåningen är avgiftsfri om böckerna återlämnades i tid. Annars tillkommer en
förseningsavgift på 10kr per påbörjad dygn för respektive bok.

Chefsapplikationen (frivillig)
Chefsapplikationen skall ge full kontroll över registret. Samtliga data i registret skall kunna hanteras.
Det skall vara möjligt att söka på, lägga till, ta bort och ändra data för böcker, bokningar, expediter,
medlemmar och fakturor. Mer specifikt skall chefen kunna välja att göra något av följande:
• Hantering av expediter. Expediter skall kunna läggas till och lösenord ändras.
• Hantering av kunder. Kunder skall kunna läggas till och uppgifter för befintliga kunder
skall kunna ändras.
• Hantering av böcker. Nya böckerskall kunna läggas till och uppgifter för befintliga böcker
skall kunna ändras. Dessutom skall man kunna söka ut tillgängliga böcker, bokade böcker
och böcker som inte har återlämnats i tid.
• Sökning av fakturor. Man skall kunna söka ut fakturor för ett visst datumintervall eller för
en viss kund.

Datamodell
Det finns data som systemet måste kunna hantera och som beskrivs kort här.
• En bok har ett ISBN-nummer och en titel (författare, förlag, mm behöver inte tas med).
• En medlem har ett medlemsnummer, namn, telefonnummer och epostadress.
• För en bokning måste systemet spara medlemmens medlemsnummer, den tilltänkta
starttiden och återlämningstiden samt expeditens anställningsnummer.
• För en faktura måste systemet spara motsvarande bokning, de faktiska start och
återlämningstiderna samt totalpriset.
• För expediter och chefer måste systemet spara anställningsnummer, namn, lösenord och roll
(expedit eller chef).

Krav
Då syftet med laborationen är att visa förmågan att kunna tillämpa en iterativ process för
objektorienterad analys och design för mjukvaruutveckling så behöver ett antal olika artefakter
lämnas in:
1. Användningsfall för expeditapplikationen. Dessa behöver i slutänden vara såpass förfinade
att det finns ett huvudflöde med numrerade steg.
2. Domänmodell med de noterbara konceptuella klasserna i problemdomänen och relationerna
mellan dessa.
3. Systemsekvensdiagram för huvudflödena (happy path) av respektive användningsfall som
identifierar de systemoperationer som finns.
4. Minst ett systemoperationskontrakt för en av de identifierade systemoperationerna.
5. Ett designsekvensdiagram för var och en av alla systemoperationer i huvudflödet för
Bokning av böcker och Återlämning av böcker som fördelar ut ansvaret för respektive
operation till lämpliga klasser.
6. Ett påbörjat C# projekt (av typ class library) för expeditapplikationens affärslager där de
klasser med metoder, properties och attribut som används i designsekvensdiagramen för
Bokning av böcker och Återlämning av böcker finns med. Här skall också finnas interna
klasser enligt Repository mönstret för att lagra böcker, medlemmar, bokningar, fakturor och
anställda i RAM minnet (så ingen databas här).
7. Designklassdiagram över de klasser som skapats för systemoperationerna i huvudflödet för
Bokning av böcker och Återlämning av böcker. Kan med fördel skapas i Visual Studio.
Notera att de här kraven inte löses som 1-2-3-…-7 i sin helhet utan som del av 1-2-3-…-7 och sedan
nästa del av 1-2-3-…-7 osv. 

Se Tips nedan.
Expeditapplikationen skall vara skiktad i två lager eftersom vi inte har någon databas under att
kommunicera med:
• Ett simpelt presentationslager (t.ex. Windows Forms) för att testa affärslagret med avseende
på Bokning av böcker och Återlämning av böcker.
• Ett konkret affärslager (Class Library), med ifyllda metoder för Bokning av böcker och
Återlämning av böcker samt intern datalagring i RAM-minnet (in-memory) via Repository
mönstret men ingen databas under.
Affärslagret och dess gränssnitt uppåt och internt skall vara objektorienterat, d.v.s. det skall ge
tillgång till objekt som representerar viktiga saker eller koncept i applikationens domän.
Diagrammen som krävs kan skapas för hand eller i ett lämpligt program (t.ex. Visio).
Lösningen skall vara uppdelad i lämpliga klasser. Varje klass (abstrakt eller konkret) och interface
skall vara definierad i en egen fil. Arv och polymorfism skall utnyttjas där så är lämpligt. Klasser
och metoder skall vara väl kommenterade och även i övrigt ska koden vara prydlig. De publika
metoderna i affärslagrets gränssnitt får endast returnera objekt/värden av specifika typer eller en
uppräkning av objekt av en specifik typ (t.ex. List<Foo>, IEnumerable<Foo> eller
IQueryable<Foo>). Helt ospecifika typer som t.ex. Object får inte förekomma i gränssnitt.

Tips
Visual Studio kan skapa designklassdiagram direkt från C# kod. Dessa skapas och läggs till i ett
projekt via Add->New Item och finns under Visual C# Items->General->Class Diagram i
dialogen som öppnas. Klasser kan dras och släppas i diagrammet. Hur metoder och attribut visas kan
justeras. Det är också möjligt att skapa och utforma en klass i diagrammet och automatiskt skapa ett
kodskelett för den.
Följande steg är ett förslag på en finfördelad iterativ agil OOAD-process:
1. Gör ett utkast till domänmodell från problembeskrivning och användningsfall.
2. Välj ett användningsfall och förfina det om så krävs.
2.1. Gör ett systemsekvensdiagram av (ett scenario i) användningsfallet för att hitta
systemoperationer samt förfina därefter domänmodellen.
2.2. Välj en systemoperation (och gör eventuellt ett systemoperationskontrakt och förfina
domänmodellen) samt påbörja designarbetet:
2.2.1. Gör designsekvensdiagram, tilldela ansvar, osv. för klasser i affärslagret som behövs
 för att utföra systemoperationen.
2.2.2. Sammanfatta klasserna i ett designklassdiagram. Dessa kan eventuellt istället
 genereras från koden efter steg 2.2.3.
2.2.3. Skriv/utöka ett C# projekt (av typ class library) för applikationens affärslager där de
klasser med metoder, properties och attribut som används i designsekvensdiagramen
finns med. Det behöver inte finnas någon funktionalitet i metoderna, förutom för de
som hör till Bokning av böcker och Återlämning av böcker.
2.2.4. Uppdatera domänmodellen och/eller användningsfallsmodellen om ny kunskap
framkommit för dessa.
2.3. Repetera steg 2.2 för fler systemoperationer.
Repetera steg 1-2 för fler användningsfall.
Skiktningen av lösningen underlättas genom att lägga varje lager i ett eget projekt inom lösningen
(solution). Projekten skall ha referenser till varandra där det behövs, t.ex. känner
användargränssnittsprojektet till affärslagerprojektet och affärslagerprojektet känner till
datalagerprojektet. Däremot skall inte användargränssnittet referera direkt till datalagerprojektet. För
att lägga till referenser, högerklicka på projektet och välj Add Reference och klicka sen på Projects
och välj önskat projekt.

Redovisning
Ni skall arbeta i grupper om 3 studenter. Ni ansvarar själva för att finna arbetskamrater för er grupp
och att meddela detta via Doodle-sidan för gruppval, som finns på PingPong.
Uppgiften redovisas enligt listan i avsnittet Krav ovan. Packa ihop (med Zip) alla dokument samt
hela biblioteket med er C# lösning och ladda upp detta till PingPong. Om Zip-arkivet försvinner vid
inlämningen, se till att gå igenom C# projeket och ta bort eventuella .exe eller .dll filer och försök
igen. I en C# lösning behöver inte bin/ och obj/ foldrarna i respektive projekt tas med. Om ni tar bort
dessa så bör det inte finnas några .exe eller .dll filer kvar i arkivet.
Handledning
Det finns 3 handledningstillfällen utlagda i KronoX (28 januari, 4 februari, 28 februari). Ni kan
endast utnyttja en tid per handledningstillfälle per grupp. Boka handledningstid via doodlelänkarna
i PingPong.
Examinationer
Varje laborationsmoment examineras vid 3 tillfällen (5 februari, 9 mars, 5 juni) klockan 23:59.
Högskolepoäng och betyg
Endast betygen underkänt (U) eller godkänt (G) kan fås på laborationen, som ger 1,5 högskolepoäng
vid godkänt (G).
