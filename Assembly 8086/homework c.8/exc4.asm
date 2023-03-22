.MODEL small
.STACK 100h
.DATA

.CODE

    mov ax, @data
    mov ds, ax
    xor ax, ax
    
    mov [30h], 25h
    mov [32h], 3Ah
    mov [34h], 7Bh
    mov [36h], 93h

    mov si, 30h
    mov cl, 4
    mov ch, 4
    mov bh, 0
A1: 
    mov ax, [si]
    mov bl, al
    ror bl, cl
    dec bl
    mov [si], bx
    add si, 2
    dec ch        
    cmp ch, 0
    jne A1
    
END