function createAlert() {
    alert("Hey this is an alert");
}

function createPrompt(question) {
    return prompt(question);
}

function setElement(id, text) {
    document.getElementById(id).innerText = text;
}

function giveMeRandom(mxSize) {
    DotNet.invokeMethodAsync('SerAppDataGrid', 'GetRandomNumbers', mxSize)
        .then(result => {
            setElement('randomNumbers', result);
        });
}