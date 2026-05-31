window.coachpro = window.coachpro || {};

window.coachpro.getFileNames = (elementId) => {
  try {
    const input = document.getElementById(elementId);
    if (!input || !input.files) return [];
    const names = [];
    for (let i = 0; i < input.files.length; i++) {
      names.push(input.files[i].name);
    }
    return names;
  } catch (e) {
    return [];
  }
};
