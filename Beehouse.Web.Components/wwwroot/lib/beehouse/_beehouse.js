// Function to load necessary libraries
function beehouseLoadLibraries() {
    document.body.appendChild(beehouseCreateJqueryNode());
    document.body.appendChild(beehouseCreateBootstrapNode());
    document.body.appendChild(beehouseCreateJqueryMaskNode());
    document.body.appendChild(beehouseCreateBeehouseMaskNode());
    document.body.appendChild(beehouseCreateBeehouseSelectNode());
    document.body.appendChild(beehouseCreateBeehouseModelNode());
}

function beehouseCreateBeehouseMaskNode() {
    return beehouseCreateScriptNode("_content/Beehouse.Web.Components/lib/beehouse/BeehouseMask.js");
}

function beehouseCreateBeehouseSelectNode() {
    return beehouseCreateScriptNode("_content/Beehouse.Web.Components/lib/beehouse/BeehouseSelect.js");
}

function beehouseCreateBeehouseModelNode() {
    return beehouseCreateScriptNode("_content/Beehouse.Web.Components/lib/beehouse/BeehouseModal.js");
}

function beehouseCreateJqueryMaskNode() {
    return beehouseCreateScriptNode("_content/Beehouse.Web.Components/lib/jquery-mask-plugin/dist/jquery.mask.js");
}

function beehouseCreateJqueryNode() {
    return beehouseCreateScriptNode("_content/Beehouse.Web.Components/lib/jquery/dist/jquery.js");
}

function beehouseCreateBootstrapNode() {
    return beehouseCreateScriptNode("_content/Beehouse.Web.Components/lib/bootstrap/dist/js/bootstrap.js");
}

function beehouseCreateScriptNode(source) {
    var node = document.createElement("script");
    node.async = false;
    node.src = source;

    return node;
}

// Beehouse Init
beehouseLoadLibraries();