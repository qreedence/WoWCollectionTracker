function saveSearchModelToLocalStorage(key, value) {
    localStorage.setItem(key, JSON.stringify(value));
}

function getSearchModelFromLocalStorage(key) {
    var value = localStorage.getItem(key);
    return value ? JSON.parse(value) : null;
}

function removeSearchModelFromLocalStorage(key) {
    localStorage.removeItem(key);
}

function reloadPage() {
    window.location.reload();
}