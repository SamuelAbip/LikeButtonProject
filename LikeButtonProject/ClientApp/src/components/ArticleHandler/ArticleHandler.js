import React, { useEffect, useState } from "react";
import classes from "./ArticleHandler.module.css";
import Spinner from "../Spinner/Spinner";
import { v4 as uuidv4 } from 'uuid';

function ArticleHandler() {
  const [getArticles, setArticles] = useState();

  useEffect(() => {
    fetch("https://localhost:5001/Article")
      .then(res => res.json())
      .then(data => setArticles(data));
  }, []);

  function onLikeHandler(index) {
    const newArticles = [...getArticles];
    if (localStorage.getItem(newArticles[index].id) !== true) {
      localStorage.setItem(newArticles[index].id, true)
      const uniqueToken = uuidv4();
      fetch("https://localhost:5001/Article/LikeArticle", {
        method: "POST",
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
          Id: uniqueToken,
          ArticleId: newArticles[index].id,
          LikeDate: new Date()
        })
      }).then(res => res.json())
        .then(data => newArticles[index].likeCount = data);
      newArticles[index].likedState = true;
      newArticles[index].likeId = uniqueToken;
      setArticles(newArticles);
    } else {
      onUnlikeHandler(index)
    }
  }

  function onUnlikeHandler(index) {
    const newArticles = [...getArticles];
    localStorage.setItem(newArticles[index].id, false)
    const bodyRequest = newArticles[index].likeId;
    fetch("https://localhost:5001/Article/UnlikeArticle", {
      method: "POST",
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(bodyRequest)
    })
      .then(res => res.json())
      .then(data => newArticles[index].likeCount = data);
    newArticles[index].likedState = false;
    setArticles(newArticles);
  };

  let articles = [];
  if (getArticles != null && getArticles.length > 0) {
    for (let index = 0; index < getArticles.length; index++) {
      const element = getArticles[index];
      articles.push(
        <div className={classes.card} key={element.id} likedState={localStorage.getItem(element.id)}>
          <p className={classes.title}>{element.title}</p>
          <p>{element.content}</p>
          <p>{element.date}</p>
          <p>{element.likeCount} LIKES</p>
          <button
            className={element.likedState ? classes.unliked : classes.liked}
            onClick={() => { element.likedState ? onUnlikeHandler(index) : onLikeHandler(index) }}>
            {element.likedState ? "LIKE ME <3" : "LIKED!"}
          </button>
        </div>
      );
    }
  } else {
    articles = <Spinner />
  };

  return (
    <div>
      <div className={classes.h1}>
        LIKE BUTTON PROJECT
      </div>
      {articles}
    </div>
  );
};

export default ArticleHandler;