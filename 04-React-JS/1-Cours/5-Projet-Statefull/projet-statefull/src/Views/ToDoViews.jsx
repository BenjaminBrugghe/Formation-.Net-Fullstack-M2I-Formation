import { React, PureComponent } from 'react';
import FormTodo from '../Components/FormTodoComponent/FormTodo';
import Notifications from '../Components/NotificationsComponent/Notifications';
import TodoDisplay from '../Components/TodoDisplayComponent/TodoDisplay';
import './ToDoViews.css';

class ToDoViews extends PureComponent {

    // Constructeur avec déclaration des states locaux

    constructor(props) {
        super(props)
        this.state = {
            todos: []
        }
    }

    // Function()

    addTodo = (text) => {
        let tmpTodos = [...this.state.todos];

        // Vérifie la dernière entrée du tableau, si vide, crée l'index 0 (première entrée), sinon, rajoutes une ID à la suite
        let newTodo = {
            id: (this.state.todos[this.state.todos.length - 1] !== undefined ? (this.state.todos[this.state.todos.length - 1].id + 1) : 1),
            status: 'undone',
            content: text
        }
        tmpTodos.push(newTodo);
        this.setState({
            todos: tmpTodos
        })
    }

    deleteTodo = (id) => {
        let tmpTodos = [];
        for (let todo of this.state.todos) {
            if (todo.id !== id) {
                tmpTodos.push(todo)
            }
        }
        this.setState({
            todos: tmpTodos
        })
    }

    editTodo = (id, newContent) => {
        let tmpTodos = [];
        for (let todo of this.state.todos) {
            if (todo.id === id) {
                todo.content = newContent
            }
            tmpTodos.push(todo)
        }
        this.setState({
            todos: tmpTodos
        })
    }

    // Pour modifier le 'undone'
    changeStatus = (id, newStatus) => {
        let tmpTodos = [];
        for (let todo of this.state.todos) {
            if (todo.id === id) {
                todo.status = newStatus
            }
            tmpTodos.push(todo)
        }
        this.setState({
            todos: tmpTodos
        })
    }

    render() {
        return (
            <div className='container'>
                <h2>React ToDo List</h2>

                {/* Composant pour ajouter des Todo */}

                <FormTodo addTodo={this.addTodo} />

                {/* Affichage des notifications sur le nombre de Todos */}

                <Notifications numberTask={this.state.todos.length} />

                {/* Composant pour afficher des Todo */}
                
                {this.state.todos.map((todo, index) => {
                    return (
                        <TodoDisplay key={index}
                            changeStatus={this.changeStatus}
                            editTodo={this.editTodo}
                            deleteTodo={this.deleteTodo}
                            todo={todo}
                        />
                    )
                })}

            </div>
        );
    }
}

export default ToDoViews;