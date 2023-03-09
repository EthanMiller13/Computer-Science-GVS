.MODEL small
.STACK 100h
.DATA        
    msg1 db 13, 10, 'Please insert a digit: $'
    isADigit db 13, 10, 'The number is: $'
    notADigit db 13, 10, 'The char is not a number: $'
    char db ?
.CODE
    mov ax, @data
    mov ds, ax
    
    lea dx, msg1
    mov ah, 09h
    int 21h
    
    mov ah, 01h
    int 21h
    mov char, al
    
    ; if not a digit - jump to label "not_a_digit"
    cmp char, 48
    jb not_a_digit
    
    cmp char, 57
    ja not_a_digit
    
    ; otherwise, if char is a digit - print the output
    lea dx, isADigit
    mov ah, 09h
    int 21h
    
    lea dx, char
    mov ah, 09h
    int 21h
    jmp exit
    
not_a_digit:
    lea dx, notADigit
    mov ah, 09h
    int 21h
        
exit:
    mov ah, 4Ch
    int 21h
    
END

