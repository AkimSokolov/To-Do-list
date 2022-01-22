import React , { useState } from 'react';
import './Body.css';

function Body(props){
    const [tasksInBacklog, setTasksInBacklog] = useState([]);
    const [tasksInReady, setTasksInReady] = useState([]);
    const [tasksInProgress, setTasksInProgress] = useState([]);
    const [tasksInDone, setTasksInDone] = useState([]);
    
    return(
        <div className='task-board'>
            <Dashboard />
            <div className='task-columns'>
                <TaskColumn desc = {'Backlog'} />
                <TaskColumn desc = {'Ready'} />
                <TaskColumn desc = {'In Progress'} />
                <TaskColumn desc = {'Done'} />
            </div>
        </div>
    )
}

function Dashboard(props) {
    return(
        <div className='dashboard'>
            <p className='last-task'>Last task completed on </p>
            <div className='dashboard-buttons'>
                <button>All tasks</button>
                <button>Filter</button>
                <button>Sort</button>
                <button>Rules</button>
                <button>Fields</button>
                <button>More</button>
            </div>
        </div>
    )
}

function TaskColumn(props) {

    return(
        <div className='task-column-item'>
            <p>{props.desc}</p>
            <div className='task-column-item-buttons'>
                <button>Add</button>
                <button>More</button>
            </div>
        </div>
    )
}

export default Body;