﻿using notfiy.Views.Other;
using notfiy.Views.AddToDoList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotifyViewManager = notfiy.Core.ViewManager;


namespace notfiy.Views.Todolist
{
    public partial class TodolistControl : UserControl
    {
        public TodolistControl()
        {
            InitializeComponent();
        }
        private void TodoItem_Click(object sender, EventArgs e)
        {
            TodoDetail detail = new TodoDetail();
            NotifyViewManager.MoveView(detail);

        }
        private void TodolistControl_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
        }
        private void HamburgerButton_Click(object sender, EventArgs e)
        {
            //Sidebar sidebar = new Sidebar();
            //this.Controls.Add(sidebar);
            //sidebar.BringToFront();
            //sidebar.BackColor = Color.Transparent;
            //sidebar.Location = new Point(950, 0);
            //sidebar.Show();

            Navbar navbar = new Navbar();
            this.Controls.Add(navbar);
            navbar.BringToFront();
            navbar.BackColor = Color.Transparent;
            navbar.Location = new Point(1000, 0);
        }
        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            AddToDoList.AddToDoList addtodolist = new AddToDoList.AddToDoList();
            NotifyViewManager.MoveView(addtodolist);
        }
    }
}
