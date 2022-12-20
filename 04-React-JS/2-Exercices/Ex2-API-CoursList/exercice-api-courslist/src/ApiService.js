const __BASE_URL = 'http://localhost:3001/api';

// GET
export const getCoursApi = async () => {
    const response = await fetch(__BASE_URL + '/cours')
        .then((res) =>
            res.json()
        );
    return response.data;
}

// GET ID
export const searchCoursApi = async (id) => {
    const response = await fetch(__BASE_URL + '/cours/' + id)
        .then((res) =>
            res.json()
        );
    return response.data;
}

// POST
export const addCoursAPI = async (newCours) => {
    console.log(newCours);

    const Obj = new Headers();
    Obj.append('Content-Type','application/json');

    const monInit = {
        method:'POST',
        headers:Obj,
        body: JSON.stringify({newCours}),
        mode:'cors',
        cache:'default'
    };

    let maRequete = new Request(__BASE_URL + '/cours/');

    fetch(maRequete, monInit).then(function(reponse) {
        
    });
}

// https://developer.mozilla.org/fr/docs/Web/API/fetch



// PUT

 

// DELETE