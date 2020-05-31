console.log("BeehouseMask ----> Loading.")

window.BeehouseMask = () => {
    BeehouseUnmask();
    console.log("BeehouseMask ----> Applying masks.");
    $(".money").mask("#.##0,00",
        {
            reverse: true,
            onKeyPress: function (v, event, currentField, options) {
                // remove previously added stuff at start of string
                v = v.replace(/^0*,?0*/, '');

                // add stuff as needed
                if (v.length == 0) {
                    v = "0,00";
                }
                else if (v.length == 1) {
                    v = "0,0" + v;
                }
                else if (v.length == 2) {
                    v = "0," + v;
                }
                $(currentField).val(v);
            }
        });

    $(".number-weight").mask("#.##0,000",
        {
            reverse: true,
            onKeyPress: function (v, event, currentField, options) {
                // remove previously added stuff at start of string
                v = v.replace(/^0*,?0*/, '');

                // add stuff as needed
                if (v.length == 0) {
                    v = "0,000";
                }
                else if (v.length == 1) {
                    v = "0,00" + v;
                }
                else if (v.length == 2) {
                    v = "0,0" + v;
                }else if (v.length == 3) {
                    v = "0," + v;
                }
                $(currentField).val(v);
            }
        });

    $(".number").mask("#.##0,000", { reverse: true });
    $('.date').mask('00/00/0000');
}

window.BeehouseUnmask = () => {
    console.log("BeehouseMask ----> Unapplying masks.");
}

// Observers configuration
var target = document.querySelector('body');

// cria uma nova instância de observador
var observer = new MutationObserver(function (mutations) {
    console.log("BeehouseMask ----> Body changed.")
    mutations.forEach(function (mutation) {
        if (mutation.target.tagName === "INPUT") {
            console.log("BeehouseMask ----> INPUT Changed.")
            window.BeehouseMask();
        }
    });
});

// configuração do observador:
var config = {attributes: true, childList: true, subtree:true, characterData: true };

// passar o nó alvo, bem como as opções de observação
observer.observe(target, config);