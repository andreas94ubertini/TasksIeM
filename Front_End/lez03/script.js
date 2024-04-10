let corpo = document.getElementById("corpo-tabella");
let contenuto = "";
let counter = 0
function salva(){
    
    let nome = document.getElementById("nome").value;
    let cognome = document.getElementById("cognome").value;
    let telefono = document.getElementById("telefono").value;
    if(nome !== "" && cognome !== "" && telefono !== ""){
        counter+=1
        contenuto += `
        <tr>
            <td>${counter}</td>
            <td>${nome}</td>
            <td>${cognome}</td>
            <td>${telefono}</td>
        </tr>
    `
    
    corpo.innerHTML = contenuto
    }else{
        alert("Errore compila tutti i campi")
    }

}


