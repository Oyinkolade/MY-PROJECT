async function findRecipe() {
    const input = document.getElementById("recipeInput").value;
    const output = document.getElementById("recipeOutput");

    const appId = '754909d6';
    const appKey = '11c7f4d0f3ec1957aecb4843cb8dba35';
    const response = await fetch(`https://api.edamam.com/search?q=${input}&app_id=${appId}&app_key=${appKey}`);
    const data = await response.json();

    if (data.hits.length > 0) {
        output.innerHTML = '';
        data.hits.forEach(hit => {
            const recipe = hit.recipe;
            const ingredients = recipe.ingredientLines.map(ingredient => `<li>${ingredient}</li>`).join("");
            output.innerHTML += `
                <div class="recipe">
                    <h2>${recipe.label}</h2>
                    <ul>${ingredients}</ul>
                </div>
            `;
        });
    } else {
        output.innerHTML = "<p>Recipe not found. Please try another dish.</p>";xx
    }
}