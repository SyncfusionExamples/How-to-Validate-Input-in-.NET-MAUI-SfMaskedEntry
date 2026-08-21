# How-to-Validate-Input-in-.NET-MAUI-SfMaskedEntry

## Overview

The Syncfusion .NET MAUI **SfMaskedEntry** control provides built-in validation capabilities that help ensure users enter data in the expected format. By combining input masks with validation events, developers can verify user input and provide immediate feedback when invalid values are entered. This helps improve data accuracy, reduces input errors, and enhances the overall user experience.

Input validation is an essential part of application development, especially when collecting structured information such as phone numbers, identification numbers, account numbers, or verification codes. Instead of waiting until form submission to validate data, SfMaskedEntry enables validation during user interaction, allowing applications to notify users as soon as invalid input is detected.

In this example, the SfMaskedEntry control is configured with a phone number mask and validation settings. The control validates the entered value when it loses focus. The `ValueChanged` event is used to determine whether the entered value matches the required mask format. If the input is invalid, an error message is displayed. When the user completes the mask correctly, a success message is shown.

## XAML

```xml
<inputs:SfMaskedEntry x:Name="maskedEntry"
                      WidthRequest="250"
                      Mask="00-00000 00000"
                      ClearButtonVisibility="WhileEditing"
                      HorizontalOptions="Start"
                      ValueChanged="OnMaskedEntry_ValueChanged"
                      ValidationMode="LostFocus" />
```

## C#

```csharp
private void OnMaskedEntry_ValueChanged(object sender, MaskedEntryValueChangedEventArgs e)
{
    SfMaskedEntry maskedEntry = sender as SfMaskedEntry;

    if (maskedEntry.HasError)
    {
        DisplayAlertAsync("Validation", "Enter a valid Number.", "OK");
    }

    if (e.IsMaskCompleted)
    {
        DisplayAlertAsync("Validation", "Valid phone number.", "OK");
    }
}
```

## Understanding the Properties

### Mask

The `Mask` property specifies the required input format.

```xml
Mask="00-00000 00000"
```

This mask restricts input to numeric values and automatically applies the required phone number formatting pattern.

### ValidationMode

The `ValidationMode` property determines when validation occurs.

```xml
ValidationMode="LostFocus"
```

When set to `LostFocus`, validation is triggered after the user moves focus away from the SfMaskedEntry control.

### ValueChanged

The `ValueChanged` event occurs whenever the value of the control changes.

```xml
ValueChanged="OnMaskedEntry_ValueChanged"
```

This event allows developers to perform custom validation logic and provide feedback based on the entered value.

### ClearButtonVisibility

The `ClearButtonVisibility` property controls when the clear button appears.

```xml
ClearButtonVisibility="WhileEditing"
```

The clear button is displayed only while the user is actively editing the control, making it easier to clear the entered value.

### HasError

The `HasError` property indicates whether the current input contains validation errors.

```csharp
if (maskedEntry.HasError)
{
    DisplayAlertAsync("Validation", "Enter a valid Number.", "OK");
}
```

When validation fails, an alert message is displayed to inform the user that the entered phone number is not valid.

### IsMaskCompleted

The `IsMaskCompleted` property indicates whether all required mask positions have been filled successfully.

```csharp
if (e.IsMaskCompleted)
{
    DisplayAlertAsync("Validation", "Valid phone number.", "OK");
}
```

When the mask is completed correctly, the application displays a confirmation message indicating that the entered phone number is valid.

## Output

When the application runs:

- Users can enter data only in the specified phone number format.
- Validation occurs when the control loses focus.
- An error message appears for invalid input.
- A success message appears when the mask is completed correctly.
- The clear button is displayed while editing.
- Input formatting is automatically maintained by the control.

## Benefits of Input Validation

Using SfMaskedEntry validation provides several advantages:

- Improves data accuracy.
- Reduces invalid user input.
- Provides immediate feedback.
- Enhances user experience.
- Simplifies form validation logic.
- Ensures consistent data formatting.
- Minimizes backend validation requirements.
- Creates more reliable applications.

## Use Cases

Input validation with SfMaskedEntry can be used in:

- Phone number forms.
- User registration pages.
- Employee information systems.
- Banking applications.
- Customer management solutions.
- Verification code entry screens.
- Healthcare registration forms.
- Membership and subscription