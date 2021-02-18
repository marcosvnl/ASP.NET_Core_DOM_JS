/*Essa função do JS fara com que o label aceite apenas números
 o if ((tecla > 47 && tecla < 58)) return true;
    é a númeração de teclas assim como o 
    if ((tecla > 47 && tecla < 58)) return true;
O (window.event) ? é perguntando se tiver evendo, se o campo esta
sendo preenchido.
Function ChargeColorFocus esta passando se o cursor estiver no campo
ele fica vermolho se não ele volta a ficar branco.*/


function Enum(e) {
    var tecla = (window.event) ? event.keyCode : e.which;
    if ((tecla > 47 && tecla < 58)) return true;
    else {
        if (tecla == 8 || tecla == 0) return true;
        else return false;
    }
} // function para o campo aceitar apenas números
function MascaraCPF(campo, teclaPress) {
    if (window.event) {
        var tecla = teclaPress.keyCode;
    }
    else {
        tecla = teclaPress.which;
    }
    var s = new String(campo.value);
    tam = s.length + 1;
    if (tam == 4) {
        campo.value = s.substr(0, 4) + ".";
    }
    if (tam == 8) {
        campo.value = s.substr(0, 8) + ".";
    }
    if (tam == 12) {
        campo.value = s.substr(0, 12) + "-";
    }
}
function MascaraTelefone(campo, teclaPress) {
    if (window.event) {
        var tecla = teclaPress.keyCode;
    }
    else {
        tecla = teclaPress.which;
    }
    var s = new String(campo.value);
    tam = s.length + 1;
    if (tam == 2) {
        campo.value = "(" + s.substr(0, 4);
    }
    if (tam == 4) {
        campo.value = s.substr(0, 4) + ")";
    }
    if (tam == 9) {
        campo.value = s.substr(0, 12) + "-";
    }
}

function MascaraCelular(campo, teclaPress) {
    if (window.event) {
        var tecla = teclaPress.keyCode;
    }
    else {
        tecla = teclaPress.which;
    }
    var s = new String(campo.value);
    tam = s.length + 1;
    if (tam == 2) {
        campo.value = "(" + s.substr(0, 4);
    }
    if (tam == 4) {
        campo.value = s.substr(0, 4) + ")";
    }
    if (tam == 10) {
        campo.value = s.substr(0, 12) + "-";
    }
}
function ChangeColorFocus(obj, evt) {
    if (evt.type == "focus") {
        obj.style.background = "wrey";
    }
    else if (evt.type == "blur") {
        obj.style.background = "white";
    }
}