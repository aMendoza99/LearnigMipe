import React, { useState, useEffect } from 'react';
import axios from 'axios';
import TodoItem from './TodoItem';
import TodoForm from './TodoForm';

const TodoList = () => {
  const [todos, setTodos] = useState([]);

  useEffect(() => {
    axios.get('https://localhost:<puerto>/api/todo')
      .then(response => setTodos(response.data))
      .catch(error => console.error('Error fetching data:', error));
  }, []);

  const addTodo = (newTodo) => {
    axios.post('https://localhost:<puerto>/api/todo', newTodo)
      .then(response => setTodos([...todos, response.data]))
      .catch(error => console.error('Error adding todo:', error));
  };

  const updateTodo = (id, updatedTodo) => {
    axios.put(`https://localhost:<puerto>/api/todo/${id}`, updatedTodo)
      .then(() => setTodos(todos.map(todo => (todo.id === id ? updatedTodo : todo))))
      .catch(error => console.error('Error updating todo:', error));
  };

  const deleteTodo = (id) => {
    axios.delete(`https://localhost:<puerto>/api/todo/${id}`)
      .then(() => setTodos(todos.filter(todo => todo.id !== id)))
      .catch(error => console.error('Error deleting todo:', error));
  };

  return (
    <div>
      <h1>Todo List</h1>
      <TodoForm addTodo={addTodo} />
      <ul>
        {todos.map(todo => (
          <TodoItem key={todo.id} todo={todo} updateTodo={updateTodo} deleteTodo={deleteTodo} />
        ))}
      </ul>
    </div>
  );
};

export default TodoList;
