.MODEL small
.STACK
.DATA
    var1 db 12
    var2 db 34
    result dw 0
.CODE
    mov ax, @data
    mov ds, ax
    
    mov ax, 0
    
    mov al, [var1]
    mul var2
    mov [result], ax
END

