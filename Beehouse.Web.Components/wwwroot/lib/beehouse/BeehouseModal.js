console.log("BeehouseModal ----> Loading.")

window.BeehouseModalShow = (id) => {
    console.log("BeehouseModal ----> Showing " + id + ".")
    $("#" + id).modal('show');
}

window.BeehouseModalClose = (id) => {
    console.log("BeehouseModal ----> Closing " + id + ".")
    $("#" + id).modal('hide');
}