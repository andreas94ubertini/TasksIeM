let tabella = document.getElementById("corpo-tabella");
let elenco = [];
window.addEventListener("load", ()=>{
    getLocal();
})

function stampa(ele){
    contenuto = "";
    
    for(let [idx, item] of ele.entries()){
        contenuto+=`
            <tr>
                <td>
                    ${idx + 1}
                </td>
                <td>
                    ${item.nome}
                </td>
                <td>
                    ${item.cognome}
                </td>
                <td>
                    ${item.matricola}
                </td>
                <td>
                    <button class="btn btn-danger" onclick="elimina(${idx})">X</button>
                </td>
            </tr>
        `
    }
    tabella.innerHTML= contenuto;
}

function aggiungi(){
    let varNome = document.getElementById("input-nome").value;
    let varCognome = document.getElementById("input-cognome").value;
    let varMatricola = document.getElementById("input-matricola").value;

    let stud = {
        nome: varNome,
        cognome: varCognome,
        matricola: varMatricola
    };
    elenco.push(stud);
    stampa(elenco);
    saveToLocal(elenco)
}

function elimina(id){
    elenco.splice(id,1);
    saveToLocal(elenco)
    stampa(elenco);
}

function saveToLocal(ele){
    let objson = JSON.stringify(ele);
    localStorage.setItem("elenco",objson);
}

function getLocal(){
    let elencoString = localStorage.getItem("elenco");
    let newElenco = JSON.parse(elencoString);
    elenco = newElenco;
    stampa(elenco);
}