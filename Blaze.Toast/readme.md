Blaze Toast is a simple toast library for blazor.
To use Blaze toast
Add <i> builder.Services.AddBlazeToast(); </i> this line in the program .cs file.


And on the MainLayout.razor
 add 
         
<BlazeToasts Position="ToastPosition.TopRight"
             Timeout="50"
             ErrorIcon="fa-solid fa-xmark"
             InfoIcon="fa-solid fa-bell"
             SuccessIcon="fa-solid fa-circle-check"
             WarningIcon="fa-solid fa-triangle-exclamation"
             ShowProgressBar="@true"
             ShowCloseButton="@true">
</BlazeToasts>
this code.


You will be able to change position using position property in the toast component.
Position="ToastPosition.TopRight" 

- Top right  = ToastPosition.TopRight
- Top Left  = ToastPosition.TopLeft
- Top Center  = ToastPosition.TopCenter
- Bottom Left  = ToastPosition.BottomLeft
- Bottom Right  = ToastPosition.BottomRight
- Bottom Center  = ToastPosition.BottomCenter

