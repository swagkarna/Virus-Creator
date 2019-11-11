#include "spanishgui.h"
#include "ui_spanishgui.h"

spanishGUI::spanishGUI(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::spanishGUI)
{
    ui->setupUi(this);
}

spanishGUI::~spanishGUI()
{
    delete ui;
}
