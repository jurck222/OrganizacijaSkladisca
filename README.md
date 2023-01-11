# OrganizacijaSkladisca
Člana ekipe: 

**63190217 Jure Pavlovič** 

**63170179 Maja Lindič** 

Najina ideja za project je aplikacija za vodenje skladišča v proizvodnji. Aplikacija bi delovala v dveh delih. Prvi del je mobilna aplikacija s katero uporabnik poskenira škatle z izdelki ali materialom, ki pridejo v skladišče. Škatle imajo ponavadi v naprej določeno število kosov zato uporabniku ne bi bilo treba vnašati števila izdelkov. Ker se seveda lahko zgodi da število kosov ni popolnoma skladno s škatlami je v zadnji škatli ponavadi manj kosov, kar v proizvodnij označijo na škatli in je v aplikaciji tudi možnost ročnega vnosa števila. Vsaka vrsta izdelka oz škatla bi imela svojo šifro na katero je vezano tudi število kosov v tej škatli. Ko uporabnik poskenira škatlo mora potem to tudi potrditi s pritiskom na gumb saj se lahko zgodi, da je ponesreči poskeniral eno škatlo 2x ali pa je poskeniral napačno škatlo. Na mobilni napravi se uporabniku po skeniranju prikaže tudi par osnovnih informacij o izdelku, da lahko uporabnik preveri ali so mu dostavili pravilne kose. Ko uporabnik zaključi s skeniranjem skupine škatel (npr. Ene palete) mora vnesti še lokacijo kje v skladišču bodo shranjene te škatle saj so skladišča v proizvodnjah ponavadi razdeljena na različne cone. Na koncu se vnese še šifra naloga pri katerem so bili kosi narejeni in se vse skupaj shrani v podatkovno bazo. Drugi del aplikacije pa bi bil namizna aplikacija kjer bi uporabnik vnesel šifro izdelka ali pa naloga in bi mu aplikacija iz podatkovne baze prikazala kje se kosi nahajajo, Koliko jih je in ali je nalog končan. Ko kosi zapustijo skladišče zopet sledi skeniranje. Najprej se poskenira škatle nato nalog in v podatkovni bazi se ustrezno označijo ali pa celo izbrišejo zapisi za te kose
![article page](https://user-images.githubusercontent.com/56190152/211871488-dc7ba54e-f7df-45cb-8092-fb1e952c7f12.png)
![order page](https://user-images.githubusercontent.com/56190152/211871496-f16bbcdd-c7f9-46f9-8dd8-7978c4c07f68.png)
![whouse page](https://user-images.githubusercontent.com/56190152/211871505-28de32fc-598b-47d4-9dc9-f0d57144d09b.png)
![profile](https://user-images.githubusercontent.com/56190152/211871522-223ba7d1-e5b2-4a6b-a47d-e16632a9fa4a.png)
**Jure Pavlovič naloge:**
Generiranje osnovnega ogordja aplikacije in osnovne baze, ki je bila kasneje izboljšana. Objava aplikacije v azure in vključitev swagger. Dodajanje rolov in urejanje pravic ter dbinitializer.
