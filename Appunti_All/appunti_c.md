# C#

- Main
    - blocco di codice eseguito come entry point.
    - é un metodo static e fa parte della classe Program
- Staging area: 
### Contenitori di tipi di dati
- Array statico, occupa porzioni di memoria sequenziali
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

## Astrazione
- 
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
- IEnumerable=>ICollection=>IList=>List
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


## Javascript
- Interpretato runtime
- quando il codice non è presente all'interno dell'html, posso bloccare il codice all'interno della console in sources