# C#
- Microservizio: 
- OOP paradigma strutturazione e organizzazione dati
- Main
    - blocco di codice eseguito come entry point.
    - é un metodo static e fa parte della classe Program
- Staging area: parte in cui fai add del commit
- Funzione: 
- composizione: relazione fra oggetti che esiste solo quando almeno uno va a comporla
- aggregazione: relazione fra oggetti che esistono a preiscindere indipendemente l'uno dell'altro
### Contenitori di tipi di dati
- Array statico, occupa porzioni di memoria sequenziali, sequenza di valori omogenei
- List array dinamici occupano porzioni di memoria sfalsati grazie al puntatore sequenziale
(array di supporto con i puntatori di memoria)
- Tupla : array eterogeneo di tipo object, permette di  mettere diversi tipi che ereditano tutti da object
- HashTable: ogni singolo elemento ha un identificativo univoco che lo caratterizza (array associativo, coppie chiave valore), permette di storare diversi tipi, l'identificativo deve essere di tipo primitivo, non è permessa la modifica del dato inserito.
Per ciclare un ht va usato il tipo "**DictionaryEntry**", non è un approccio TypeSafe.
- Dictionary: come un hashtable ma typesafe, va tipizzata sia la chiave che il valore, si cicla con "**KeyVAluePair<Type>**", si usa quando hai certezza del dato
- Enumerator: contenitori che sono contabili

## Polimorfismo
- Capacità di una variabile di essere dichiarata come classe del padre e di trasformsi nella classe figlia a runtime;
- Binding dinamico, tipizzazione generica, si trasforma a runtime, succede solo se il codice viene eseguito
- il polimorfismo avviene solo in ereditarietà  
- il polimorfismo permette di ovviare alla problematica della tipizzazione forte o typesafe
- 3 situazioni di polimorfismo, tramite interfaccia,tramite superclasse e classe astratta
- Nasce per ovviare al problema dei contenitore omegenei
- Object: classe dalla quale ereditano tutte le altri classe, contiene metodi base 
    - (Object.ToEquals, metodo contenuto dentro object), impronta(codice univoco "hash" che comparato permette di comparare in modo ottimizzato), funzione non invertente, MD5 32 caratteri 

## Ereditarità
- nella classe padre per poter effetturare l'ereditarità è necessario avere il costruttore di default  

## Astrazione 
- Forma di ereditarità in cui non si può craere la classe padre
- override dei metodi abstract nelle classi figlie
## Incapsulamento
- Capacità di una classe di nascondere le propietà dall'esterno (data hiding), e renderle accessibili solo attraverso i metodi
- Gli attributi private non vengono ereditati, si userà protected per non violare il principio di incapsulamento

## Static
- prima dell'esecuzione del programma, verranno cercate tutti gli attributi static e si allocherà della memoria. Sono attributi di classe e non dell'oggetto istanziato


## LINQ
- 

##
- Inferenza del generico tipo, inserimento del tipo nelle <> ad esempio nelle liste o nelle interface <T>

## 
- Configuration builder: installare nuGet extension, extension json, oggetto che serve per creare tramite build() un interfaccia, 

- Iconfiguration: interfaccia che crea in automatico il metodo per reperire le informazioni dal'app setting, 

-  
## Singleton
- Pattern creazionale 
- Processo per il quale una classe viene istanziata soltanto una sola volta
- variabile private static di tipo uguale alla classe istanziata
- creazione metodo public static GetIstance() che ritorna il tipo di appartenenza della classe {
    se l'istanza è null creo l'istanza
}
- impostare il costruttore come private
- serve a creare un oggetto una volta sola   
        private static Config? istanza;
        public static Config getIstanza()
        {
            if (istanza == null)
                istanza = new Config();

            return istanza;
        }
        private Config(){}

## Libreria standard ado.net

## ORM Object Relational Mapping
- database first
- code first
- Contesto: funzionalità di ef che permette di usare linq (file che viene creato da ef e ci connette al db)
- Da installare
    - sqlDataClient
    - entityframework core
    - entityframeworktools
    - entityframeworkcoresqlserver
- passare comando nella console nuget Scaffold-DbContext "Server= ACEDEMY2024-04\SQLEXPRESS;Database=acc_lez07_otm_carta;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
- Scaffhold: operazione di creazione strutture (Contenitori)
- Icollection: Interfaccia che si specializza quando la si utlizza, sfrutta il polimorfismo sull'interfaccia
- IEnumerable=>ICollection=>IList=>List (ogni livello aggiunge metodi di appartenenza)
- Migration: equivalente di ddl , permette di trasformare le classi di c# con le relative notazioni in tabelle sql
## Data Transfer Object
- pattern trasferimento dati
- 
## WPF
- windows presentation fountation, set di funzionalità per applicazioni stand alone, 
- schema: direttive di scrittura e riconoscimento  

## HTML
- Staseless
- Markup: set di istruzioni per organizzare testo
- Browser: 
- Render: rappresentazione, web renderer (HTML CSS), eseguito dalla scheda video
- V8 engine: Javascript eseguito dal processore
- Tag strutturali (ex body, head(contiene le direttive)), di contenuto
- Tag meta: contentono properties e non hanno tag di chiusura
- Segment, parti del percorso di una path, separati da /  
- Statefull: capacità di un sistema di immagazzinare variabili per renderle disponibili successivamente
  

## Javascript
- Interpretato runtime
- quando il codice non è presente all'interno dell'html, posso bloccare il codice all'interno della console in sources
- Var non sicuro per quanto riguarda la conservazione del valore contenuto, variabile ridichiarabile con lo stesso nome
- Ecmscript: standardizzazione di js 2015 prima volta
- Scope: contesto di js, la pagina o il contesto (sottoprogramma es) nel quale viene incluso
- Variabile di scope,variabile accessibile nel proprio contesto (file di appartenenza)
- Prototype, serie di funzionalità che permette di aggiungere e rimuovere valori
- Set: new Set([]), sequenza di operazioni che non ammettono la permanenza di contenuto uguale
- Map : struttura dati chiave valore
- Size, propietà computata  
- Promises => Resolve/ Rejected (fetch=> response/resolve)

## Rest Api
- Architettura client server, pattern di programmazione, (protocollo http) hhtp request=> http response
- web server: interpretatore di request e emettitore di response
- client (browser) , emette request, interpreta response 
- RestFull Api: representational state transer application programming interface (comunicazione tamite file json),
costrusce gli end point in modo specifico e differenzia la propria caratterizazzione rispetto a quelli che sono i metodi definiti nel backend
ASP: active server pages, identifica una tecnologia client server nel mondo dotnet
- Action: responso che deve essere generato dall'attivazione di un metodo
- Add scoped, utilizzato per creare e distruggere l'oggetto quando viene utilizzato, contrario di singleton
- pattern facade, visualizzazione di soli componenti connessi controller->service->repository->database
- dto: clone per trasportare solo attributi che vogliamo esporre della classe originale (model), 
- mimetype: istruzione che viene inviata per decodificare la risposta

-http get: richiesta dati, passaggio di dati tramite stringa, contiene mittente e destinatario dentro l'header, numero di caratteri limitato rispetto alla post
-http post: passaggio di dati, caratterizzato dalla presenza di un payload o body che contiene i dati effettivi da passare sotto forma di json o xml

- serializzatore, processo che rende in tipo stringa gli object
- buffer overflow, sovraccarico di allocazione della memoria ram 
- 

## Typescript
- superset funzioni (layer aggiuntivo su js), per renderlo type safe, è un linguaggio compilato, input typescript output javascript 
-  comportamento aperto: tipizzazione non coerente ma riconosciuta
- parametri opzionali ?, messi sempre per ultimi nel costruttore, nel caso ce ne fossero più di uno, andranno passati come undefined nell'ordine di dichiarazione del costruttore
- aggiungere documentazione con /**
- moduli: 

# OOP
- 


## NodeJS
- Js v8, NPM componenti di node

## Angular
- Framework front end, (PWA applicazione che viene inviata al browser già assemblata)
- RxJs 
- ssr molto più veloce ma più esoso a livello di spazio occupato
- package lock, file che contiene le istruzioni per riscaricare tutti i file del progetto
- Jasmine: sistema di testing automation di Angular
- @component : notazione, contiene la configurazione (view), la classe è il controller (declaration: genere il tag da innestare)
- node-modules: file che contiene tutte le direttive da riversare nel file js compilato da passare al browser
- Model View/ View Model 
- Bootstrap : fase di avvio nel quale controlla e dopo compila i suoi componenti
- Declaration in appModules: elenco della componenti da utilizzare nel progetto
- Module: dichiarazioni delle componenti da utilizzare
- Imports in appModules: librerie esterne 
- AppRoot: gestisce le varie componenti, andranno innestati dentro di lui per ritrovali nell'effettivo html
- OnInit: avviene dopo l'inizializazione del componente, ovvero dopo aver effettivamente creato l'html
- Injection: possibilità di creare una propietà e iniettarla direttamente nel costruttore, vanno autorizzate tramite il provider (fornisce la tipologia di elemento), 
- --no-standalone crea l'app module
- Route, chiave valore 
- debugger: attiva il debugger nella riga corrispondente
- Observables: (interrompibile a differenza delle promises)
- BehaviorSubject:
- Router: classe principale che gestisce tutti gli indirizzi
- Coercizione di tipo cast esplicito del tipo imposto <Type>
- ### form
    - ngModel [()] campo da riempire che verrà sincronizzato con una variabile all'imterno del component legati dal nome

## Razor Pages asp.net
- Linguaggio server side: codice eseguito all'interno del server, verrà inviata una pagina comp ilata stateless al front end
- Fatserver Thinclient(Business logic e composizione del dom), il client rimane scarico in quanto non deve elaborare nulla
- ViewBag, per passare dati semplici, si imposta con l'annotazione ViewBag.NomeVar = Value 

### Sicurezza:

- Cookie, la prima volta il server tramite la http response invierà le info per creare il cookie che verrà successivamente create dal client, e rimane nel client e verrà usato nelle successive http request 
- Gateway: gestisce le richieste e smista dentro le altre pagine
- Session: cookie che viene conservato lato server, quindi sicuro per effettuare processi di autenticazione, verrà spedito un cookie con il numero della session che verrà poi utilizzata per la veririfica
- attacco csrf