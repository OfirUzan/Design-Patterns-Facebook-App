﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;

namespace Model
{
    public class WallHanndler
    {
        private FacebookObjectCollection<Post> m_Wall;
        private int m_PostIndex;
        private int m_CommentIndex;
        private int m_PicturePostCount;
        private string m_CurrCommentId;
        private string m_CurrPostId;


        public WallHanndler(FacebookObjectCollection<Post> i_Wall)
        {
            m_Wall = i_Wall;
            m_PostIndex = -1;
            m_CommentIndex = 0;
            foreach (Post post in m_Wall)
            {
                if (post.Type == Post.eType.photo)
                {
                    m_PicturePostCount++;
                }
            }
        }

        public Post getNextWallPost()
        {
            Post post;
            if (m_PicturePostCount == 0)
            {
                post = null;
            }
            else
            {
                m_CommentIndex = 0;
                if (m_PostIndex == m_Wall.Count - 1)
                {
                    m_PostIndex = 0;
                }


                post = m_Wall[++m_PostIndex];

                if (post.Type != Post.eType.photo)
                {
                    post = this.getNextWallPost();
                }
            }

            //m_CurrPostId = post.Id;
            m_CurrPostId = post.Link;
            return post;
        }

        public Comment getNextCommentOfCurrentPost()
        {
            Comment comment;
            try
            {
                if (m_Wall[m_PostIndex].Comments.Count == 0)
                {
                    comment = null;
                    m_CurrCommentId = null;
                }
                else
                {
                    if (m_CommentIndex == m_Wall[m_PostIndex].Comments.Count)
                    {
                        m_CommentIndex = 0;
                    }

                    comment = m_Wall[m_PostIndex].Comments[m_CommentIndex++];
                    m_CurrCommentId = comment.Id;
                }
            }
            catch (Exception e)
            {
                comment = null;
                m_CurrCommentId = null;
            }

            return comment;
        }
        
        public string getCommentID()
        {
            return (m_CurrCommentId);
        }
        public string getPostId()
        {
            return (m_CurrPostId);
        }
    }
}
