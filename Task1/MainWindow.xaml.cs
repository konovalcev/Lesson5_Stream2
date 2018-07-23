﻿using System;
using System.Collections.ObjectModel;
using System.Windows;

// Изменить WPF-приложение для ведения списка сотрудников компании(из урока №5), используя связывание данных, ListView, ObservableCollection и INotifyPropertyChanged.
// 1. Создать сущности Employee и Department и заполнить списки сущностей начальными данными.
// 2. Для списка сотрудников и списка департаментов предусмотреть визуализацию(отображение). Это можно сделать, например, с использованием ComboBox или ListView.
// 3. Предусмотреть возможность редактирования сотрудников и департаментов.Должна быть возможность изменить департамент у сотрудника. Список департаментов для выбора, можно выводить в ComboBox, это все можно выводить на дополнительной форме.
// 4. Предусмотреть возможность создания новых сотрудников и департаментов.Реализовать данную возможность либо на форме редактирования, либо сделать новую форму.

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Department> departments = new ObservableCollection<Department>();
        Department vocal = new Department(nameof(vocal));
        Department guitar = new Department(nameof(guitar));
        Department drums = new Department(nameof(drums));
        public MainWindow()
        {
            InitializeComponent();
            FillList();
        }

        private void FillList()
        {
            departments.Add(vocal);
            departments.Add(guitar);
            departments.Add(drums);
            employees.Add(new Employee("John", "Lennon", 30, 1001, vocal));
            employees.Add(new Employee("Paul", "McCartney", 28, 1002, vocal));
            employees.Add(new Employee("George", "Harrison", 27, 1003, guitar));
            employees.Add(new Employee("Ringo", "Starr", 30, 1004, drums));
            lbEmployees.ItemsSource = employees;
            lbDepartments.ItemsSource = departments;
        }

        private void lbEmployees_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void lbDepartments_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}