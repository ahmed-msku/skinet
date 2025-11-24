var message = 'Hello';
var isComplete = false;
var todos = [];
function addTodo(title) {
    var newTodo = {
        id: todos.length + 1,
        title: title,
        completed: false,
    };
    todos.push(newTodo);
    return newTodo;
}
function totggleTodo(id) {
    var todo = todos.find(function (todo) { return todo.id == id; });
    if (todo) {
        todo.completed = !todo.completed;
    }
}
addTodo('Build API');
addTodo('Publish app');
totggleTodo(1);
console.log(todos);
