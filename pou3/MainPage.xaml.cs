﻿using Microsoft.Maui.Controls;

namespace pou3;

public partial class MainPage : ContentPage
{

    dog1 atual;
    creatina poodol;
    pinscher01 pinscher;
    //_________________________________________________________________________
    public MainPage()
    {
        InitializeComponent();

        poodol = new creatina();
        pinscher = new pinscher01();
        atual = new dog1();

        Progresscomida.Progress = atual.comida;
        Progressagua.Progress= atual.agua;
        Progressdiversao.Progress= atual.diversao;


        imgpersonage.Source = atual.();
    }

}

