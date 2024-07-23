import React from 'react';

const TodoItem = ({ todo, updateTodo, deleteTodo }) => {
  const toggleComplete = () => {
    updateTodo(todo.id, {
      ...todo,
      isComplete: !todo.isComplete
    });
  };

  return (
    <li>
      <span
        style={{ textDecoration: todo.isComplete ? 'line-through' : 'none' }}
        onClick={toggleComplete}
      >
        {todo.name}
      </span>
      <button onClick={() => deleteTodo(todo.id)}>Delete</button>
    </li>
  );
};

export default TodoItem;
