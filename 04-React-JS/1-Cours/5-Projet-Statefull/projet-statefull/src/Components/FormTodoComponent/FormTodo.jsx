import React, { PureComponent } from 'react';
import './FormTodo.css';

class FormTodo extends PureComponent {

    constructor(props) {
        super(props)
        this.state = {
            contentTask: ""
        }
    }

    Submit = (e) => {
        e.preventDefault();
        if (this.state.contentTask !== "") {
            this.props.addTodo(this.state.contentTask);
            this.setState({
                contentTask: ""
            })
        }
    }

    ChangeTask = (e) => {
        this.setState({
            contentTask: e.target.value
        })
    }

    render() {
        return (
            <form className='row m-1' onSubmit={this.Submit}>
                <div className="col-9">
                    <input
                        className='form-control'
                        type="text"
                        onChange={this.ChangeTask}
                        placeholder='Contenu de la Todo List'
                        value={this.state.contentTask}
                    />
                </div>
                <div className="col-3">
                    <button
                        type='submit'
                        className='form-control btn btn-secondary'
                    >Ajouter</button>
                </div>
            </form>
        );
    }
}

export default FormTodo;