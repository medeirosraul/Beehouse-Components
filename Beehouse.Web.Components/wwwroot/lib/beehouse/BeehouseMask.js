console.log("BeehouseMask ----> Loading.")

window.BeehouseMask = () => {
    BeehouseUnmask();
    console.log("BeehouseMask ----> Applying masks.");
    $(".money").mask("#.##0,00", { reverse: true });
    $(".number").mask("#.##0,000", { reverse: true });
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