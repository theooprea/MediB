MediB - an app by Bulangii de la ACS

	credits to - Corcodel Iulia Maria
		   - Oprea Theodor-Alin
		   - Verna Dorian Alexandru
		   - Virtan Razvan Nicolae

SCURTA DESCRIERE

MediB este un raspuns atat la nevoia de a avea un sistem de date medicale centralizat
pentru medici, prin care acestia sa poata accesa istoricul medical complet al oricarui asigurat si
sa poata face programari rapid, intr-o interfata grafica, cat si la necesitate 
unui dosar electronic al pacientului, pe care acesta sa il poata accesa usor mereu. Aplicatia are doua
parti principale: aplicatia pentru windows, care va fi utilizata de personalul
medical autorizat, si o aplicatie pentru mobil, care va fi folosita de catre
pacient, oferindu-i acestuia posibilitatea de a vizualiza propriile date si de
a avea mereu la indemana propriul dosar medical, cu toate documentele necesare.

WINDOWS

- Aplicatia de windows este realizata folosind windows forms application, fiind
folosite mai multe formuri care joaca rolul de pagini in aplicatie, care cu
ajutorul butoanelor si al altor elemente de GUI implementeaza anumite feature-uri.

- Aplicatia porneste cu meniul de logare, care trimite un HTTP Request de tip
Post catre baza de date. In cazul in care este un login valid se va primi un
token, pe baza caruia se va adauga un header la viitoarele requesturi, actiunile
fiind validate. Daca loginul este validat se lanseaza meniul doctorului din care
acesta se poate deloga, poate cauta si adauga pacienti in baza de date, poate
adauga programari si vizualiza pe cele existente. 

- Crearea pacientului se face printr-un form in care se completeaza datele necesare.

- Cautarea pacientului, daca e validata de server, va deschide un form in care poate vedea datele
existente ale acestuia, datele generale sau consulturile, dar si sa descarce
retete, bilete de trimitere, imagistica sau analize apasand pe butoanele
respective, alegand apoi in functie de numele afisate pe care sa il descarce.
Pentru a adauga consulturi doctorul va apasa pe consulturi apoi pe Add Entry,
iar daca doreste adaugarea unui PDF acesta va apasa direct pe Add Entry, care
va deschide un nou form, cu ajutorul caruia va alege fisierul de incarcat.

- Pentru a vedea alt pacient sau pentru a se intoarce la meniul sau, medicul apasa
butonul de back. Pentru a afisa/adauga programari va apasa din meniul medicului
butonul de programari, care va deschide o pagina din care va alege o data de pe
calendar si in functie de butonul apasat va putea adauga/afisa programari
in ziua aleasa. Programul se inchide o data cu inchiderea ferestrei
princicpale.

APLICATIA MOBILA (a pacientului)
- este dezvoltata folosind Xamarin.Forms si Visual Studio, pentru a fi adaptabila
atat la platforme Android, cat si iOS, si pentru a putea scrie aplicatia in
limbajul C#.
- aplicatia se ocupa doar cu preluarea de date de la server, folosind metode GET,
singura metoda POST fiind folosita pentru formularul de login.
- autentificarea este realizata pe baza de token-uri
- la realizarea request-urilor am folosit clasele HttpClient, HttpResponseMessage
si HttpContent, iar pentru parsarea raspunsurilor primite de la server in format
Json, este utilizata biblioteca Newtonsoft.Json
- cu ajutorul unui meniu (realizat folosind tipul de pagina Master-Detail Page si
tool-ul ListView), pacientul poate alege sa vizualizeze datele personale (incluse
intr-un ListView), pdf-urile care contin fisele cu analizele sale medicale, retete,
imagistica sau bilete de trimitere, sau informatiile cele mai importante legate de
consulturi din trecut sau programari viitoare (prezentate intr-un format de tip
CardView, realizat astfel incat sa nu intampine probleme mari de afisare, indiferent
de sistemul de operare).
- pacientul devine astfel mai responsabil, avand acces constant la toate datele lui
medicale si putand sa revizuiasca periodic toate recomandarile primite la consulturile
medicale. De asemenea, este eliminat stresul legat de alergatul la farmacii si medicii
cu foarte multe hartii, deoarece practic putem avea permanent in buzunar toate retetele,
biletele de trimitere si analizele necesare.

