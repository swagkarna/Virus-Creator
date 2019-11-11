/********************************************************************************
** Form generated from reading UI file 'spanishgui.ui'
**
** Created by: Qt User Interface Compiler version 5.12.5
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SPANISHGUI_H
#define UI_SPANISHGUI_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_spanishGUI
{
public:
    QPushButton *saveButton;
    QLabel *label;
    QTextEdit *textEdit;

    void setupUi(QWidget *spanishGUI)
    {
        if (spanishGUI->objectName().isEmpty())
            spanishGUI->setObjectName(QString::fromUtf8("spanishGUI"));
        spanishGUI->resize(861, 517);
        saveButton = new QPushButton(spanishGUI);
        saveButton->setObjectName(QString::fromUtf8("saveButton"));
        saveButton->setGeometry(QRect(360, 390, 201, 61));
        QFont font;
        font.setPointSize(26);
        saveButton->setFont(font);
        label = new QLabel(spanishGUI);
        label->setObjectName(QString::fromUtf8("label"));
        label->setGeometry(QRect(40, 40, 131, 31));
        QFont font1;
        font1.setPointSize(17);
        label->setFont(font1);
        textEdit = new QTextEdit(spanishGUI);
        textEdit->setObjectName(QString::fromUtf8("textEdit"));
        textEdit->setGeometry(QRect(190, 40, 181, 41));

        retranslateUi(spanishGUI);

        QMetaObject::connectSlotsByName(spanishGUI);
    } // setupUi

    void retranslateUi(QWidget *spanishGUI)
    {
        spanishGUI->setWindowTitle(QApplication::translate("spanishGUI", "Form", nullptr));
        saveButton->setText(QApplication::translate("spanishGUI", "Continue", nullptr));
        label->setText(QApplication::translate("spanishGUI", "Virus Name:", nullptr));
    } // retranslateUi

};

namespace Ui {
    class spanishGUI: public Ui_spanishGUI {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SPANISHGUI_H
