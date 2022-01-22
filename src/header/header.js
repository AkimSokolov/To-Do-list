import React from 'react';
import './header.css';
import logo from './logo.jpg';

function Header() {
    return (
        <div className="header">
            <div className="nav">
                <img className="logo" src={logo} alt="logo"/>
                <div className="navbar">
                    <h2>Sprint Plans</h2>
                    <div className="nav-links">
                        <a className="link" href="#">Overview</a>
                        <a className="link" href="#">List</a>
                        <a className="link" href="#">Board</a>
                        <a className="link" href="#">Timeline</a>
                        <a className="link" href="#">Calendar</a>
                        <a className="link" href="#">Dashboard</a>
                        <a className="link" href="#">Messages</a>
                        <a className="link" href="#">More...</a>
                    </div>
                </div>
            </div>
            <div className="users-board">
                <div className="users"></div>
                <div className="board">
                    <input className="search-input" type="text"/>
                    <button className="header-btn">&#128931;</button>
                </div>
            </div>
        </div>
    );
}

export default Header