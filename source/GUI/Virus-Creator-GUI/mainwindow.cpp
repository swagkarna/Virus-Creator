#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QMessageBox>

//Import UI headers
#include "spanishgui.h"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_English_Button_clicked()
{
    QMessageBox::warning(this, tr("ERROR"), tr("I'm working on the english version, Please wait."));
}

void MainWindow::on_Spanish_Button_clicked()
{
    spanishGUI spanishWindow;
    spanishWindow.setEnabled(true);
    spanishWindow.show();

}
