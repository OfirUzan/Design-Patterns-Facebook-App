﻿using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using View.AssistiveComponents;

namespace View.AssistiveFroms
{
    public partial class UserEventsForm : Form
    {
        #region Class Members / Properties
        public Button ButtonGetEvents
        {
            get
            {
                return (m_userEventsComponent as UserEventsComponent).ButtonGetEvents;
            }

            set
            {
                (m_userEventsComponent as UserEventsComponent).ButtonGetEvents = value;
            }
        }

        public BindingSource BindingSource
        {
            get
            {
                return (m_userEventsComponent as UserEventsComponent).EventsBindingSource;
            }

            set
            {
                (m_userEventsComponent as UserEventsComponent).EventsBindingSource = value;
            }
        }

        public DataGridView DataGridView
        {
            get
            {
                return (m_userEventsComponent as UserEventsComponent).DataGridView;
            }

            set
            {
                (m_userEventsComponent as UserEventsComponent).DataGridView = value;
            }
        }

        public DataGridViewTextBoxColumn LocationColumn
        {
            get
            {
                return (m_userEventsComponent as UserEventsComponent).LocationColumn;
            }

            set
            {
                (m_userEventsComponent as UserEventsComponent).LocationColumn = value;
            }
        }
        #endregion

        #region Class Methods
        public UserEventsForm(User i_User)
        {
            InitializeComponent();
            m_userEventsComponent = AppComponentFactory.CreateAppComponent(Utils.eAppComponent.UserEvents, Controls, i_User);
            m_userEventsComponent.Initialize();
        }
        #endregion
    }
}
