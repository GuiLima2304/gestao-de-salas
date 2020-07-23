import React, { useState, useEffect, Component, ChangeEvent, FormEvent } from 'react';
import './style.css';
import logo from '../../assets/logo.png';
import api from '../../services/api';
import Modal from 'react-modal';

Modal.setAppElement('#root');

const customStyles = {
    content : {
      top                   : '20%',
      left                  : '10%',
      right                 : '10%',
      bottom                : '20%'
    }
  };

interface Room {
    id: number;
    name: string;
    description: string;
}

interface Scheduling {
    id: number;
    title: string;
    startDate: string;
    endDate: string;
    roomId: number;
}


const Home = () => {

    const [rooms, setRooms] = useState<Room[]>([]);
    const [scheduling, setScheduling] = useState<Scheduling[]>([]);

    const [newRoom, setNewRoom] = useState(false);

    function handleInputChangeRoom(event: ChangeEvent<HTMLInputElement>) {
        const { name, value } = event.target;

        setFormDataRoom({ ...formDataRoom, [name]: value })
    }

    async function PostNewRoom(event: FormEvent) {
        event.preventDefault();

        const { name, description } = formDataRoom;

        const data = { name, description }

        await api.post('Sala', data);

        alert('Sala criado!');
        window.location.reload();

    }

    const [formDataRoom, setFormDataRoom] = useState({
        name: '',
        description: ''
    });
    
    useEffect(() => {
        api.get('Sala').then(response => {
            setRooms(response.data);
        })
    }, []);

    useEffect(() => {
        api.get('Agendamento').then(response => {
            setScheduling(response.data);
        })
    }, []);

    async function DeleteRoom(id:number) {
        await api.delete('Sala/'+ id);
        window.location.reload();
        
    }

    async function DeleteScheduling(id:number) {
        await api.delete('Agendamento/'+ id);
        window.location.reload();
    }

    return (
        <div id="page-home">
            <div className="content">
                <header>
                    <img src={logo} alt="smarapd"></img>
                    <p>Gestão de agendamento</p>
                    <button onClick={() => setNewRoom(true)}>Nova Sala</button>
                    <button>Novo Agendamento</button>
                </header>
                <main>
                <h3>Salas</h3>
                   <div id="rooms">
                        {rooms.map(item => (
                            <li key={item.id}>
                                <h4>Sala: {item.name}</h4>
                                <h5>Descrição {item.description}</h5>
                                <button onClick={() => DeleteRoom(item.id)}>Deletar</button>
                                <button>Editar</button>
                            </li>
                        ))}
                   </div>

                <h3>Agendamentos</h3>
                   <div id="schedulings">
                        {scheduling.map(scheduling => (
                            <li key={scheduling.id}>
                                <h5>Titulo: {scheduling.title}</h5>
                                <h5>Inicio: {scheduling.startDate}</h5>
                                <h5>Fim: {scheduling.endDate}</h5>
                                <h5>Sala: {scheduling.roomId}</h5>
                                <button onClick={() => DeleteScheduling(scheduling.id)}>Deletar</button>
                                <button>Editar</button>
                            </li>
                        ))}
                   </div>
                    
                    <div>
                        <Modal isOpen={newRoom} style={customStyles}>
                            <h2>Nova Sala</h2>

                            <div className="field">
                                <label htmlFor="name">Nome da sala</label>
                                <input
                                    type="text"
                                    name="name"
                                    onChange={handleInputChangeRoom}>
                                </input>
                            </div>

                            <div className="field">
                                <label htmlFor="description">Descricao da sala</label>
                                <input
                                    type="text"
                                    name="description"
                                    id="description"
                                    onChange={handleInputChangeRoom}>
                                </input>
                            </div>

                            <button onClick={() => setNewRoom(false)}>Fechar</button>
                            <button onClick={PostNewRoom}>Salvar</button>

                        </Modal>
                    </div>
                </main>
            </div>
        </div>
    );
}

export default Home;