import React, { Component, useState, useEffect } from 'react';


const RankItem = () => {

    const [items, setItems] = useState([]);
    const dataType = 1;

    useEffect(() => {
        fetch(`itemmodel/Get`)
         .then((results) => { results.json()
    })
        .then(data => {
            setItems(data);
        })
},[])


    return (
        <main>
            {
                (items != null) ? items.map((item) => <h3>{item.Name}</h3>) : <div>Loading...</div>
            }
        </main>)
}
export default RankItem;