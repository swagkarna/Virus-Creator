#ifndef SPANISHGUI_H
#define SPANISHGUI_H

#include <QWidget>

namespace Ui {
class spanishGUI;
}

class spanishGUI : public QWidget
{
    Q_OBJECT

public:
    explicit spanishGUI(QWidget *parent = nullptr);
    ~spanishGUI();

private:
    Ui::spanishGUI *ui;
};

#endif // SPANISHGUI_H
