exports.success = (message,data) => {return {message,data}};

exports.getUniqueId = (coursList) => {
    const coursIds = coursList.map(cours = cours.id);
    const maxId = coursIds.reduce((a,b) => Math.max(a,b));
    const UniqueId = maxId + 1;
    return UniqueId;
}