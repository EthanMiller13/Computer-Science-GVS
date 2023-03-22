.MODEL small
.STACK 100h
.DATA
    array db ?, ?, ?, ?, ?
    msg1 db 13, 10, 'Enter five chars: $'
    offset db ?
.CODE
    mov ax, @data
    mov ds, ax
    
    xor cx, cx
    mov cx, 5
    
get_a_char:
    lea dx, msg1
    mov ah, 09h
    int 21h
    
    mov ah, 1h
    int 21h
    
    mov bx, 5
    sub bx, cx
    mov [array+bx], al
    
    loop get_a_char
    
exit:
    mov ah, 4Ch
    int 21h    
END