# SQL
## Sistema informativo
 - Big Data => Data Lake
 - un sistema informativo è una combinazione di risorse umane e materiali e di procedure organizzate per la raccolta, l'archiviazione, l'elaborazione e lo scmabio di informazioni necessarie all'attività operative, alle attività di gestione e alle attività di programmazione controllo e valutazione.
 - Il termine sistema evidenzia il fatto che esiste un insieme organizzativo di elementi.
 - ogni sistema informativo comprende raccolte di informazioni di tipo omogeneo
## Il sistema informatico
 - Indica l'insieme degli strumenti informatici per il trattamento automatico delle informazioni al fine di agvolare le funzioni del sistema informativo
 - In un sistema informatico le informazioni sono rappresentate per mezzo di dati

## Data Base Management 
System (DBMS)
- una base di dati è una collezione di dati atti a rappresentare le informazioni 
che interessano un sistema informativo
- un SGBD è un sistema software in grado di gestire (costruire, modificare, 
utilizzare, …) una base dati
- Sistemi di recupero delle informazioni (SRI) o Information Retrieval 
System (IRS)

## Caratteristiche di un DB
- Un DB è costituito da una grande quantità di dati, organizzati in 
    insiemi omogenei in correlazione tra loro
    - i dati sono memorizzati e gestiti in memoria permanente (disco)
    - i dati sono condivisi fra più utenti e fra più applicazioni per ridurre la 
        ridondanza e la possibilità di inconsistenze.
- In un DB esiste:
    - (Importante)una parte sostanzialmente invariante nel tempo, detto schema della base di 
    dati, che descrive le caratteristiche dei dati (struttura dati e relazioni)
    - una parte variabile nel tempo, detta istanza o stato del DB, costituita dai valori 
effettivi dei dati
- accezione generica, metodologica
    - insieme organizzato di dati utilizzati per il supporto allo svolgimento delle 
        attività di un ente (azienda, ufficio, persona)
- accezione specifica, metodologica e tecnologica 
    - insieme di dati gestito da un DBMS
- colonne: lo schema della relazione
- righe: l'istanza della relazione
- metadato: descrizione del tipo della variabile
## CARATTERISTICHE DEI DATI GESTITI DAI DBMS
- Sono organizzati in insiemi omogenei, fra i quali sono definite delle 
relazioni. La struttura dei dati e le relazioni sono descritte nello schema 
usando i meccanismi di astrazione del modello dei dati del DBMS;
- Sono molti, in assoluto e rispetto ai metadati, e non possono essere gestiti 
in memoria temporanea;
- Sono accessibili mediante transazioni, unità di lavoro atomiche che non 
possono avere effetti parziali;
- Sono protetti sia da accesso da parte di utenti non autorizzati, sia da 
corruzione dovuta a malfunzionamenti hardware e software;
- Sono utilizzabili contemporaneamente da utenti diversi

- DDL: data definition language linguaggio di manipolazione della parte invariante (schema) (DB, tabelle, struttura), es: il corpo della query (contenitore)
- Vincolo interno: (UNIQUE)
- Vincolo esterno (FK), vincolo di identità relazionale
- DML: data manipulation language, linguaggio manipolazione dei dati (contenuto delle tabelle), insert modify e delete delle righe (contenuto)
- QL: query language: richiesta dei dati
- DBO: database object: contenitore di tuple, riga che non ha contenuto omogeno

- Transazione: blocco di istruzioni che viene eseguito nella sua totalità o non verrà eseguito parzialmente
- Dump: copie di backup del database sottoforma di insert
- Proiezione verticale (filtraggio), mostra solo i campi selezionati con la QL, non crea una nuova tabella!
- NVARCHAR: crea una struttura a tutte le lingue
- VARCHAR: specifica dizionario del server di destinazione

- Tabella d'appoggio: tabella che racchiude due campi di relazione in una relazione molti a    molti
- Tabella temporanea, si distingue per il # prima del nome, servono per visualizzare dati e vengono droppate subito dopo
- Quando in una tabella non è espressa una PK ma c'è una chiave UNIQUE, viene assegnata automaticamente come PK eletta (sconsigliata se prende campi string in riferimento per via delle performance)
- 

## Stored Procedures
- Righe di codice salvate, richiamabili con passaggio di parametri che possono contenere dei metodi, all'interno possono esserci ql e dml, ma possiamo anche usare ddl con tabelle temporanee
- Errori personalizzati, codice sopra i 50.000 sono liberi e personalizzabili, messaggio personalizzato, classe che indica la priorità (1 max)

- La rollback evita effetti parziali di una transazione(Blocco di codice che deve essere eseguito in maniera totale)

- Cursore: protoforma di ciclo
- connessione, canale di comunicazione
- connection pool, canali di comincazione sql max 100
