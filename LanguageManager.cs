using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class LanguageManager
{
    public static Dictionary<string, string> EnglishTexts = new Dictionary<string, string>()
    {   //for login page
        { "UsernameLabel", "Username" },
        { "PasswordLabel", "Password" },
        { "LoginButton", "Login" },
        { "FormTitle", "Login Page" },
        //for signup page
        { "SignupTitle", "Sign Up" },
        { "FirstNamePlaceholder", "First Name" },
        { "LastNamePlaceholder", "Last Name" },
        { "EmailPlaceholder", "Enter Email" },
        { "PasswordPlaceholder", "Enter Password" },
        { "ShowPasswordCheckbox", "Show Password" },
        { "SignupButton", "Sign Up" },
        { "AlreadyHaveAccountLabel", "Already have an account?" },
        { "LoginButtonBelow", "Login" },
        //for taskform
        { "CreateTaskTitle", "Create Task" },
        { "TaskTitlePlaceholder", "Task Title" },
        { "DescriptionLabel", "Description" },
        { "PriorityLabel", "Priority" },
        { "StatusLabel", "Status" },
        { "LabelLabel", "Label" },
        { "AddTaskButton", "Add Task" },
        //for settingspage
        {"SettingsTitle","Settings"},
        {"ProfileLabel", "Profile" },
        {"CFNLabel","Change First Name"},
        {"CFLLabel","Change Last Name"},
        {"CPLabel","Change Password"},
        {"CButton","Change"},
        {"OL", "Options" },
        {"PomoL","Pomodoro" },
        {"Short","ShortBreak"},
        {"LongL","LongBreak" },
        {"SoL","Sounds" },
        {"StButton","Stop" },
        {"RL","Rating"},
        {"SButton","Stop"},
        {"LangL","Language" },
        {"FeedL","Feedback"},
        {"FL","Your feedback means alot to us"},
        {"SubButton","Submit" },
        {"Lbutton","Log Out" },
        //for pomodoro page
        {"PomodBut","Pomodoro"},
        {"StartButton","Start"},
        {"StopButton","Stop"},
        {"ShortBreakButton","Short Break"},
        {"LongBreakButton","Long Break"},
        //for main form
        {"NavBarTitle","Aleena | Muaz | FSE Project" },
        {"NavPomodist","Pomodist" },
        {"NavDashboard","Dashboard" },
        {"NavToDoList","To Do List" },
        {"NavCalendar","Calendar" },
        {"NavSettings","Settings" },
        //for to do list
        {"ToDoListLabel","To Do List" },
        {"addTaskButton","Add Task" },
        //for task panel
        
        {"TaskPanelDescription","Description" },
        {"TaskPanelPriority","Priority" },
        {"TaskPanelStatus","Status" },
        {"TaskPanelLabel","Label" },
        {"TaskPanelEditButton","Edit" },
        {"TaskPanelDeleteButton","Delete" },
        {"TaskPanelCompleteButton","Complete" },
        {"TaskPanelStartDate","Start Time" },
        {"TaskPanelEndDate","End Time" },
        //for calendar
        {"Monday","Monday" },
        {"Tuesday","Tuesday" },
        {"Wednesday","Wednesday" },
        {"Thursday","Thursday" },
        {"Friday","Friday" },
        {"Saturday","Saturday" },
        {"Sunday","Sunday" },
        //dashboard
        {"DashboardLabel","Dashboard" }


    };

    public static Dictionary<string, string> FrenchTexts = new Dictionary<string, string>()
    {   //for login page
        { "UsernameLabel", "Nom d'utilisateur" },
        { "PasswordLabel", "Mot de passe" },
        { "LoginButton", "Connexion" },
        { "FormTitle", "Page de connexion" },

        //for signup page
        { "SignupTitle", "Inscription" },
        { "FirstNamePlaceholder", "Prénom" },
        { "LastNamePlaceholder", "Nom de famille" },
        { "EmailPlaceholder", "Entrer l'email" },
        { "PasswordPlaceholder", "Entrer le mot de passe" },
        { "ShowPasswordCheckbox", "Afficher le mot de passe" },
        { "SignupButton", "S'inscrire" },
        { "AlreadyHaveAccountLabel", "Vous avez déjà un compte ?" },
        { "LoginButtonBelow", "Connexion" },
        //for taskform
        { "CreateTaskTitle", "Créer une tâche" },
        { "TaskTitlePlaceholder", "Titre de la tâche" },
        { "DescriptionLabel", "Description" },
        { "PriorityLabel", "Priorité" },
        { "StatusLabel", "Statut" },
        { "LabelLabel", "Étiquette" },
        { "AddTaskButton", "Ajouter la tâche" },
        //for settings page
        {"SettingsTitle", "Paramètres"},
        {"ProfileLabel", "Profil"},
        {"CFNLabel", "Changer le prénom"},
        {"CFLLabel", "Changer le nom de famille"},
        {"CPLabel", "Changer le mot de passe"},
        {"CButton", "Changer"},
        {"OL", "Options"},
        {"PomoL", "Pomodoro"},
        {"Short", "Pause courte"},
        {"LongL", "Pause longue"},
        {"SoL", "Sons"},
        {"StButton", "Arrêter"},
        {"RL", "Évaluation"},
        {"SButton", "Arrêter"},
        {"LangL", "Langue"},
        {"FeedL", "Retour"},
        {"FL", "Vos retours sont très importants pour nous"},
        {"SubButton", "Soumettre"},
        {"Lbutton", "Se déconnecter"},
    //for pomdoro page
        { "PomodBut", "Pomodoro" },
        { "StartButton", "Démarrer" },
        { "StopButton", "Arrêter" },
        { "ShortBreakButton", "Pause courte" },
        { "LongBreakButton", "Pause longue" },
        // for main form
        { "NavBarTitle", "Aleena | Muaz | Projet FSE" },
        { "NavPomodist", "Pomodist" },
        { "NavDashboard", "Tableau de bord" },
        { "NavToDoList", "Liste de tâches" },
        { "NavCalendar", "Calendrier" },
        { "NavSettings", "Paramètres" },
        // for to do list
        { "ToDoListLabel", "Liste de tâches" },
        { "addTaskButton", "Ajouter une tâche" },
        // for task panel
        { "TaskPanelDescription", "Description" },
        { "TaskPanelPriority", "Priorité" },
        { "TaskPanelStatus", "Statut" },
        { "TaskPanelLabel", "Étiquette" },
        { "TaskPanelEditButton", "Modifier" },
        { "TaskPanelDeleteButton", "Supprimer" },
        { "TaskPanelCompleteButton", "Terminer" },
        { "TaskPanelStartDate", "Heure de début" },
        { "TaskPanelEndDate", "Heure de fin" },
        // for calendar
        { "Monday", "Lundi" },
        { "Tuesday", "Mardi" },
        { "Wednesday", "Mercredi" },
        { "Thursday", "Jeudi" },
        { "Friday", "Vendredi" },
        { "Saturday", "Samedi" },
        { "Sunday", "Dimanche" },
        // dashboard
        { "DashboardLabel", "Tableau de bord" }

    };
    public static Dictionary<string, string> HindiTexts = new Dictionary<string, string>()
{   
    // for login page
    { "UsernameLabel", "उपयोगकर्ता नाम" },
    { "PasswordLabel", "पासवर्ड" },
    { "LoginButton", "लॉगिन" },
    { "FormTitle", "लॉगिन पेज" },

    // for signup page
    { "SignupTitle", "साइन अप" },
    { "FirstNamePlaceholder", "पहला नाम" },
    { "LastNamePlaceholder", "अंतिम नाम" },
    { "EmailPlaceholder", "ईमेल दर्ज करें" },
    { "PasswordPlaceholder", "पासवर्ड दर्ज करें" },
    { "ShowPasswordCheckbox", "पासवर्ड दिखाएं" },
    { "SignupButton", "साइन अप करें" },
    { "AlreadyHaveAccountLabel", "क्या आपके पास पहले से खाता है?" },
    { "LoginButtonBelow", "लॉगिन" },

    // for taskform
    { "CreateTaskTitle", "कार्य बनाएँ" },
    { "TaskTitlePlaceholder", "कार्य का शीर्षक" },
    { "DescriptionLabel", "विवरण" },
    { "PriorityLabel", "प्राथमिकता" },
    { "StatusLabel", "स्थिति" },
    { "LabelLabel", "लेबल" },
    { "AddTaskButton", "कार्य जोड़ें" },

    // for settings page
    { "SettingsTitle", "सेटिंग्स" },
    { "ProfileLabel", "प्रोफ़ाइल" },
    { "CFNLabel", "पहला नाम बदलें" },
    { "CFLLabel", "अंतिम नाम बदलें" },
    { "CPLabel", "पासवर्ड बदलें" },
    { "CButton", "बदलें" },
    { "OL", "विकल्प" },
    { "PomoL", "पोमोडोरो" },
    { "Short", "छोटा ब्रेक" },
    { "LongL", "लंबा ब्रेक" },
    { "SoL", "ध्वनि" },
    { "StButton", "रोकें" },
    { "RL", "रेटिंग" },
    { "SButton", "रोकें" },
    { "LangL", "भाषा" },
    { "FeedL", "प्रतिक्रिया" },
    { "FL", "आपकी प्रतिक्रिया हमारे लिए बहुत महत्वपूर्ण है" },
    { "SubButton", "सबमिट करें" },
    { "Lbutton", "लॉगआउट" },

    // for pomodoro page
    { "PomodBut", "पोमोडोरो" },
    { "StartButton", "शुरू करें" },
    { "StopButton", "रोकें" },
    { "ShortBreakButton", "छोटा ब्रेक" },
    { "LongBreakButton", "लंबा ब्रेक" },

    // for main form
    { "NavBarTitle", "अलीना | मुआज़ | FSE प्रोजेक्ट" },
    { "NavPomodist", "पोमोडिस्ट" },
    { "NavDashboard", "डैशबोर्ड" },
    { "NavToDoList", "कार्य सूची" },
    { "NavCalendar", "कैलेंडर" },
    { "NavSettings", "सेटिंग्स" },

    // for to do list
    { "ToDoListLabel", "कार्य सूची" },
    { "addTaskButton", "कार्य जोड़ें" },

    // for task panel
    { "TaskPanelDescription", "विवरण" },
    { "TaskPanelPriority", "प्राथमिकता" },
    { "TaskPanelStatus", "स्थिति" },
    { "TaskPanelLabel", "लेबल" },
    { "TaskPanelEditButton", "संपादित करें" },
    { "TaskPanelDeleteButton", "हटाएं" },
    { "TaskPanelCompleteButton", "पूरा करें" },
    { "TaskPanelStartDate", "प्रारंभ समय" },
    { "TaskPanelEndDate", "समाप्ति समय" },

    // for calendar
    { "Monday", "सोमवार" },
    { "Tuesday", "मंगलवार" },
    { "Wednesday", "बुधवार" },
    { "Thursday", "गुरुवार" },
    { "Friday", "शुक्रवार" },
    { "Saturday", "शनिवार" },
    { "Sunday", "रविवार" },

    // dashboard
    { "DashboardLabel", "डैशबोर्ड" }
};


    public static Dictionary<string, string> SpanishTexts = new Dictionary<string, string>()
    {   //for login page
        { "UsernameLabel", "Nombre de usuario" },
        { "PasswordLabel", "Contraseña" },
        { "LoginButton", "Iniciar sesión" },
        { "FormTitle", "Página de inicio de sesión" },
        //for signup page
        { "SignupTitle", "Regístrate" },
        { "FirstNamePlaceholder", "Nombre" },
        { "LastNamePlaceholder", "Apellido" },
        { "EmailPlaceholder", "Ingresar correo electrónico" },
        { "PasswordPlaceholder", "Ingresar contraseña" },
        { "ShowPasswordCheckbox", "Mostrar contraseña" },
        { "SignupButton", "Registrarse" },
        { "AlreadyHaveAccountLabel", "¿Ya tienes una cuenta?" },
        { "LoginButtonBelow", "Iniciar sesión" },
        // for taskform
        { "CreateTaskTitle", "Crear tarea" },
        { "TaskTitlePlaceholder", "Título de la tarea" },
        { "DescriptionLabel", "Descripción" },
        { "PriorityLabel", "Prioridad" },
        { "StatusLabel", "Estado" },
        { "LabelLabel", "Etiqueta" },
        { "AddTaskButton", "Agregar tarea" },
        //for setting page
        {"SettingsTitle", "Configuraciones"},
        {"ProfileLabel", "Perfil"},
        {"CFNLabel", "Cambiar Nombre"},
        {"CFLLabel", "Cambiar Apellido"},
        {"CPLabel", "Cambiar Contraseña"},
        {"CButton", "Cambiar"},
        {"OL", "Opciones"},
        {"PomoL", "Pomodoro"},
        {"Short", "Descanso corto"},
        {"LongL", "Descanso largo"},
        {"SoL", "Sonidos"},
        {"StButton", "Detener"},
        {"RL", "Valoración"},
        {"SButton", "Detener"},
        {"LangL", "Idioma"},
        {"FeedL", "Retroalimentación"},
        {"FL", "Tus comentarios significan mucho para nosotros"},
        {"SubButton", "Enviar"},
        {"Lbutton", "Cerrar sesión"},
    //for pomdoro page
        { "PomodBut", "Pomodoro" },
        { "StartButton", "Comenzar" },
        { "StopButton", "Detener" },
        { "ShortBreakButton", "Pausa corta" },
        { "LongBreakButton", "Pausa larga" },
        // for main form
        { "NavBarTitle", "Aleena | Muaz | Proyecto FSE" },
        { "NavPomodist", "Pomodist" },
        { "NavDashboard", "Tablero" },
        { "NavToDoList", "Lista de tareas" },
        { "NavCalendar", "Calendario" },
        { "NavSettings", "Configuraciones" },
        // for to do list
        { "ToDoListLabel", "Lista de tareas" },
        { "addTaskButton", "Agregar tarea" },
        // for task panel
        { "TaskPanelDescription", "Descripción" },
        { "TaskPanelPriority", "Prioridad" },
        { "TaskPanelStatus", "Estado" },
        { "TaskPanelLabel", "Etiqueta" },
        { "TaskPanelEditButton", "Editar" },
        { "TaskPanelDeleteButton", "Eliminar" },
        { "TaskPanelCompleteButton", "Completar" },
        { "TaskPanelStartDate", "Hora de inicio" },
        { "TaskPanelEndDate", "Hora de fin" },
        // for calendar
        { "Monday", "Lunes" },
        { "Tuesday", "Martes" },
        { "Wednesday", "Miércoles" },
        { "Thursday", "Jueves" },
        { "Friday", "Viernes" },
        { "Saturday", "Sábado" },
        { "Sunday", "Domingo" },
        // dashboard
        { "DashboardLabel", "Tablero" }



    };

    public static Dictionary<string, string> UrduTexts = new Dictionary<string, string>()
    {
        // for login page
{ "UsernameLabel", "صارف نام" },
{ "PasswordLabel", "پاس ورڈ" },
{ "LoginButton", "لاگ ان کریں" },
{ "FormTitle", "لاگ ان صفحہ" },

// for signup page
{ "SignupTitle", "رجسٹریشن" },
{ "FirstNamePlaceholder", "پہلا نام" },
{ "LastNamePlaceholder", "آخری نام" },
{ "EmailPlaceholder", "ای میل درج کریں" },
{ "PasswordPlaceholder", "پاس ورڈ درج کریں" },
{ "ShowPasswordCheckbox", "پاس ورڈ دکھائیں" },
{ "SignupButton", "رجسٹر کریں" },
{ "AlreadyHaveAccountLabel", "کیا آپ کے پاس پہلے سے اکاؤنٹ ہے؟" },
{ "LoginButtonBelow", "لاگ ان کریں" },

// for task form
{ "CreateTaskTitle", "نیا کام بنائیں" },
{ "TaskTitlePlaceholder", "کام کا عنوان" },
{ "DescriptionLabel", "تفصیل" },
{ "PriorityLabel", "ترجیح" },
{ "StatusLabel", "حالت" },
{ "LabelLabel", "لیبل" },
{ "AddTaskButton", "کام شامل کریں" },

// for settings page
{ "SettingsTitle", "ترتیبات" },
{ "ProfileLabel", "پروفائل" },
{ "CFNLabel", "پہلا نام تبدیل کریں" },
{ "CFLLabel", "آخری نام تبدیل کریں" },
{ "CPLabel", "پاس ورڈ تبدیل کریں" },
{ "CButton", "تبدیل کریں" },
{ "OL", "اختیارات" },
{ "PomoL", "پومودورو" },
{ "Short", "مختصر وقفہ" },
{ "LongL", "طویل وقفہ" },
{ "SoL", "آوازیں" },
{ "StButton", "روکیں" },
{ "RL", "درجہ بندی" },
{ "SButton", "روکیں" },
{ "LangL", "زبان" },
{ "FeedL", "آراء" },
{ "FL", "آپ کی رائے ہمارے لیے بہت اہم ہے" },
{ "SubButton", "جمع کروائیں" },
{ "Lbutton", "لاگ آؤٹ" },

// for pomodoro page
{ "PomodBut", "پومودورو" },
{ "StartButton", "شروع کریں" },
{ "StopButton", "روکیں" },
{ "ShortBreakButton", "مختصر وقفہ" },
{ "LongBreakButton", "طویل وقفہ" },
// for main form
{ "NavBarTitle", "علینہ | معاذ | ایف ایس ای پروجیکٹ" },
{ "NavPomodist", "پوموڈسٹ" },
{ "NavDashboard", "ڈیش بورڈ" },
{ "NavToDoList", "کرنے کی فہرست" },
{ "NavCalendar", "کیلنڈر" },
{ "NavSettings", "ترتیبات" },
// for to do list
{ "ToDoListLabel", "کرنے کی فہرست" },
{ "addTaskButton", "کام شامل کریں" },
// for task panel
{ "TaskPanelDescription", "تفصیل" },
{ "TaskPanelPriority", "ترجیح" },
{ "TaskPanelStatus", "حالت" },
{ "TaskPanelLabel", "لیبل" },
{ "TaskPanelEditButton", "ترمیم کریں" },
{ "TaskPanelDeleteButton", "حذف کریں" },
{ "TaskPanelCompleteButton", "مکمل کریں" },
{ "TaskPanelStartDate", "آغاز وقت" },
{ "TaskPanelEndDate", "اختتامی وقت" },
// for calendar
{ "MonthLabel", "مہینہ" },
{ "YearLabel", "سال" },
{ "Monday", "پیر" },
{ "Tuesday", "منگل" },
{ "Wednesday", "بدھ" },
{ "Thursday", "جمعرات" },
{ "Friday", "جمعہ" },
{ "Saturday", "ہفتہ" },
{ "Sunday", "اتوار" },
// dashboard
{ "DashboardLabel", "ڈیش بورڈ" }

  };
    public static Dictionary<string, string> KoreanTexts = new Dictionary<string, string>()
{   
    //for login page
    { "UsernameLabel", "사용자 이름" },
    { "PasswordLabel", "비밀번호" },
    { "LoginButton", "로그인" },
    { "FormTitle", "로그인 페이지" },

    //for signup page
    { "SignupTitle", "회원가입" },
    { "FirstNamePlaceholder", "이름" },
    { "LastNamePlaceholder", "성" },
    { "EmailPlaceholder", "이메일 입력" },
    { "PasswordPlaceholder", "비밀번호 입력" },
    { "ShowPasswordCheckbox", "비밀번호 표시" },
    { "SignupButton", "가입하기" },
    { "AlreadyHaveAccountLabel", "이미 계정이 있으신가요?" },
    { "LoginButtonBelow", "로그인" },

    //for taskform
    { "CreateTaskTitle", "작업 만들기" },
    { "TaskTitlePlaceholder", "작업 제목" },
    { "DescriptionLabel", "설명" },
    { "PriorityLabel", "우선순위" },
    { "StatusLabel", "상태" },
    { "LabelLabel", "레이블" },
    { "AddTaskButton", "작업 추가" },

    //for settings page
    {"SettingsTitle", "설정"},
    {"ProfileLabel", "프로필"},
    {"CFNLabel", "이름 변경"},
    {"CFLLabel", "성 변경"},
    {"CPLabel", "비밀번호 변경"},
    {"CButton", "변경"},
    {"OL", "옵션"},
    {"PomoL", "포모도로"},
    {"Short", "짧은 휴식"},
    {"LongL", "긴 휴식"},
    {"SoL", "소리"},
    {"StButton", "정지"},
    {"RL", "평가"},
    {"SButton", "정지"},
    {"LangL", "언어"},
    {"FeedL", "피드백"},
    {"FL", "여러분의 피드백은 저희에게 매우 중요합니다"},
    {"SubButton", "제출"},
    {"Lbutton", "로그아웃"},

    //for pomodoro page
    { "PomodBut", "포모도로" },
    { "StartButton", "시작" },
    { "StopButton", "정지" },
    { "ShortBreakButton", "짧은 휴식" },
    { "LongBreakButton", "긴 휴식" },

    // for main form
    { "NavBarTitle", "알리나 | 무아즈 | FSE 프로젝트" },
    { "NavPomodist", "포모디스트" },
    { "NavDashboard", "대시보드" },
    { "NavToDoList", "할 일 목록" },
    { "NavCalendar", "달력" },
    { "NavSettings", "설정" },
    // for to do list
    { "ToDoListLabel", "할 일 목록" },
    { "addTaskButton", "작업 추가" },
    // for task panel
    { "TaskPanelDescription", "설명" },
    { "TaskPanelPriority", "우선순위" },
    { "TaskPanelStatus", "상태" },
    { "TaskPanelLabel", "레이블" },
    { "TaskPanelEditButton", "수정" },
    { "TaskPanelDeleteButton", "삭제" },
    { "TaskPanelCompleteButton", "완료" },
    { "TaskPanelStartDate", "시작 시간" },
    { "TaskPanelEndDate", "종료 시간" },
    // for calendar
    { "MonthLabel", "월" },
    { "YearLabel", "년" },
    { "Monday", "월요일" },
    { "Tuesday", "화요일" },
    { "Wednesday", "수요일" },
    { "Thursday", "목요일" },
    { "Friday", "금요일" },
    { "Saturday", "토요일" },
    { "Sunday", "일요일" },
    // dashboard
    { "DashboardLabel", "대시보드" }

};




    // This holds the currently selected dictionary
    public static Dictionary<string, string> CurrentTexts = EnglishTexts;

    // Function to change current language
    public static void SetLanguage(string language)
    {
        if (language == "English")
            CurrentTexts = EnglishTexts;
        else if (language == "French")
            CurrentTexts = FrenchTexts;
        else if (language == "Spanish")
            CurrentTexts = SpanishTexts;
        else if (language == "Urdu")
            CurrentTexts = UrduTexts;
        else if (language == "Korean")
            CurrentTexts = KoreanTexts;
        else
            CurrentTexts = EnglishTexts; // Default to English if the language is not recognized
    }
}
