console.log("BeehouseModal ----> Loading.")

window.BeehouseModalShow = (id) => {
    console.log("BeehouseModal ----> Showing " + id + ".")
    $("#" + id).modal('show');
}

window.BeehouseModalClose = (id) => {
    console.log("BeehouseModal ----> Closing " + id + ".")
    $("#" + id).modal('hide');
}

window.BeehouseMessageBoxShow = (id, modalObject) => {
    console.log("BeehouseMessageBox ----> Showing " + id + ".");
    // Register events
    $("#" + id).off();
    $("#" + id).on("shown.bs.modal", () => {
        modalObject.invokeMethodAsync('Showed');
    });

    // Show Modal
    $("#" + id).modal('show');
}

window.BeehouseMessageBoxClose = (id, modalObject) => {
    console.log("BeehouseMessageBox ----> Showing " + id + ".");
    // Register events
    $("#" + id).off();
    $("#" + id).on("hidden.bs.modal", () => {
        modalObject.invokeMethodAsync('Closed');
    })

    // Show Modal
    $("#" + id).modal('hide');
}