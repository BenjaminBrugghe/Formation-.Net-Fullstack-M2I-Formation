import React, { PureComponent } from 'react';
import './TodoDisplay.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faTrash, faPenToSquare, faCheck } from "@fortawesome/free-solid-svg-icons";

class TodoDisplay extends PureComponent {

    constructor(props) {
        super(props)
        this.state = {
            edit: false,
            editToDoContent: undefined
        }
    }

    // Fonction Toggle 'done/undone'
    changeStatus = () => {
        const status = this.props.todo.status === 'done' ? 'undone' : 'done';
        this.props.changeStatus(this.props.todo.id, status);
        this.forceUpdate();
    }

    editTodo = () => {
        return (
            <form onSubmit={this.validEditTodo} className="col-9">
                <input
                    type="text"
                    className="form-control"
                    defaultValue={this.props.todo.content}
                    onChange={(e) => {
                        e.preventDefault();
                        this.setState({
                            editToDoContent: e.target.value
                        });
                    }}
                />
            </form>
        )
    }

    validEditTodo = (e) => {
        e.preventDefault();
        this.props.editTodo(this.props.todo.id, this.state.editToDoContent);
        this.setState({
            edit: false
        })
    }

    renderTodo = () => {
        return this.state.edit === false ?
            this.renderContentTodo() : this.editTodo();
    }

    renderContentTodo = () => {
        return (
            <div
                onClick={this.changeStatus}
                className={(this.props.todo.status === 'done') ?
                    ('btn col-9 text-success') : ('btn col-9 text-danger')
                }>
                {this.props.todo.content}
            </div>
        )
    }

    renderDoneOrUndoneButton = () => {
        return this.props.todo.status === 'done' ?
            <FontAwesomeIcon
                icon={faCheck}
                onClick={this.changeStatus}
                className="green"
            />
            :
            <FontAwesomeIcon
                icon={faCheck}
                onClick={this.changeStatus}
                className="red"
            />
    }

    render() {
        return (
            <div className='row'>
                <div className="col-9">
                    {this.renderTodo()}
                </div>

                <div className="col-1">
                    {this.renderDoneOrUndoneButton()}
                </div>
                <div className="col-1">
                    <FontAwesomeIcon
                        icon={faPenToSquare}
                        className="icon"
                        onClick={() => {
                            this.setState({
                                edit: true
                            })
                        }}
                    />
                </div>
                <div className="col-1">
                    <FontAwesomeIcon
                        icon={faTrash}
                        className="icon"
                        onClick={() => {
                            this.props.deleteTodo(this.props.todo.id)
                        }}
                    />
                </div>
            </div>
        );
    }
}

export default TodoDisplay;